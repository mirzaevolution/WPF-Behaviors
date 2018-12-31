using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace AttachedPropertiesDemo
{
    public enum BackgroundType
    {
        None = 0,
        Primary = 1,
        Danger = 2,
        Success = 3,
        Info = 4 
    }
    public class ControlBackgroundTypes
    {


        public static BackgroundType GetBackgroundType(DependencyObject obj)
        {
            return (BackgroundType)obj.GetValue(BackgroundTypeProperty);
        }

        public static void SetBackgroundType(DependencyObject obj, BackgroundType value)
        {
            obj.SetValue(BackgroundTypeProperty, value);
        }

        // Using a DependencyProperty as the backing store for BackgroundType.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackgroundTypeProperty =
            DependencyProperty.RegisterAttached("BackgroundType", 
                typeof(BackgroundType), 
                typeof(ControlBackgroundTypes), new PropertyMetadata(BackgroundType.None,OnBackgroundChanged));

        private static void OnBackgroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            
            
            if (d is Panel panel)
            {
                switch (e.NewValue)
                {
                    case BackgroundType.Primary:
                        {
                            panel.Background = new SolidColorBrush(Colors.RoyalBlue);
                            break;
                        }
                    case BackgroundType.Danger:
                        {
                            panel.Background = new SolidColorBrush(Color.FromRgb(255, 51, 51));
                            break;
                        }
                    case BackgroundType.Success:
                        {
                            panel.Background = new SolidColorBrush(Color.FromRgb(77, 255, 77));
                            break;
                        }
                    case BackgroundType.Info:
                        {
                            panel.Background = new SolidColorBrush(Color.FromRgb(128, 179, 255));
                            break;
                        }
                }
            }
            else if (d is Border border)
            {
                switch (e.NewValue)
                {
                    case BackgroundType.Primary:
                        {
                            border.Background = new SolidColorBrush(Colors.RoyalBlue);
                            break;
                        }
                    case BackgroundType.Danger:
                        {
                            border.Background = new SolidColorBrush(Color.FromRgb(255, 51, 51));
                            break;
                        }
                    case BackgroundType.Success:
                        {
                            border.Background = new SolidColorBrush(Color.FromRgb(77, 255, 77));
                            break;
                        }
                    case BackgroundType.Info:
                        {
                            border.Background = new SolidColorBrush(Color.FromRgb(128, 179, 255));
                            break;
                        }
                }
            }
            else  if (d is Control control)
            {
                switch (e.NewValue)
                {
                    case BackgroundType.Primary:
                        {
                            control.Background = new SolidColorBrush(Colors.RoyalBlue);
                            break;
                        }
                    case BackgroundType.Danger:
                        {
                            control.Background = new SolidColorBrush(Color.FromRgb(255, 51, 51));
                            break;
                        }
                    case BackgroundType.Success:
                        {
                            control.Background = new SolidColorBrush(Color.FromRgb(77, 255, 77));
                            break;
                        }
                    case BackgroundType.Info:
                        {
                            control.Background = new SolidColorBrush(Color.FromRgb(128, 179, 255));
                            break;
                        }
                }
            }
        }
    }
}
