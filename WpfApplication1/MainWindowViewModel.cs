using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfApplication1
{
    class MainWindowViewModel
    {

        public static readonly DependencyProperty WindowWidthProperty = 
        DependencyProperty.Register("WindowWidth", typeof(double),typeof(MainWindow));
        public static readonly DependencyProperty WindowHeightProperty =
        DependencyProperty.Register("WindowHeight", typeof(double), typeof(MainWindow));

        public double WindowWidth { get { return (System.Windows.SystemParameters.WorkArea.Width - 20); } }
        public double WindowHeight { get { return (System.Windows.SystemParameters.WorkArea.Height - 20); } }

    }



    public class WidthToParentConverter : IValueConverter
    {
        public static readonly DependencyProperty WindowWidthProperty =
        DependencyProperty.Register("WindowWidth", typeof(double), typeof(MainWindow));
        //public static readonly DependencyProperty WindowHeightProperty =
        //DependencyProperty.Register("WindowHeight", typeof(double), typeof(MainWindow));

        public double Adjustment { get { return 10; } }
        public double WindowWidth { get { return (System.Windows.SystemParameters.WorkArea.Width - Adjustment); } }
        //public double WindowHeight { get { return (System.Windows.SystemParameters.WorkArea.Height - 20); } }


        object IValueConverter.Convert(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            double width = (double)value;
            double adjustment = Convert.ToDouble(parameter);

            return width + adjustment;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            double width = (double)value;
            double adjustment = Convert.ToDouble(parameter);

            return width - adjustment;
        }
    }
}
