using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BasicDependencyProperties
{
    public class MyData:INotifyPropertyChanged
    {
        private int _value;

        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
    public partial class MyUserControl : UserControl
    {
        public MyData MyData { get; set; } = new MyData();
        public MyUserControl()
        {
            MyData.Value = 42;
            InitializeComponent();
            DataContext = MyData;
        }


        public int Speed
        {
            get { return (int)GetValue(SpeedProperty); }
            set { SetValue(SpeedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Speed.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SpeedProperty =
            DependencyProperty.Register("Speed", typeof(int), typeof(MyUserControl), 
                new PropertyMetadata(42, OnSpeedChanged));

        private static void OnSpeedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MyUserControl userControl = d as MyUserControl;
            ((MyData)userControl.DataContext).Value = (int)e.NewValue;
        }
    }
}
