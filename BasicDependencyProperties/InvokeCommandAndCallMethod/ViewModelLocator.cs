using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InvokeCommandAndCallMethod
{
    public static class ViewModelLocator
    {


        public static bool GetViewLocation(DependencyObject obj)
        {
            return (bool)obj.GetValue(ViewLocationProperty);
        }

        public static void SetViewLocation(DependencyObject obj, bool value)
        {
            obj.SetValue(ViewLocationProperty, value);
        }

        // Using a DependencyProperty as the backing store for ViewLocation.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ViewLocationProperty =
            DependencyProperty.RegisterAttached("ViewLocation", typeof(bool), typeof(ViewModelLocator), new PropertyMetadata(false,OnValueChanged));

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var viewType = d.GetType();
            var viewName = viewType.FullName;
            var viewModelName = viewName + "ViewModel";
            var viewModel = Activator.CreateInstance(Type.GetType(viewModelName));
            ((FrameworkElement)d).DataContext = viewModel;
        }
    }
}
