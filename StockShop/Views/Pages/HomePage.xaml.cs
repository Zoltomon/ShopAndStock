using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.Wpf;
using OxyPlot;
using System;
using System.Collections.Generic;
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

namespace StockShop.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        private PlotModel plotModel { get; set; }
        public HomePage()
        {
            InitializeComponent();
            DataContext = this;
            InitializePlot();
        }
        private void InitializePlot()
        {
            plotModel = new PlotModel();
            var linearAxisY = new LinearAxis
            {
                Position = AxisPosition.Left,
                Minimum = 10000,
                Maximum = 10000000,
                Title = "Сумма (рубли)"
            };
            plotModel.Axes.Add(linearAxisY);

            var dateTimeAxisX = new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Дата",
                StringFormat = "dd.MM.yyyy"
            };
            plotModel.Axes.Add(dateTimeAxisX);

            var series = new LineSeries
            {
                Title = "График"
            };

            var dataPoints = new List<DataPoint>
        {
            new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 10, 1)), 15000),
            new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 10, 5)), 50000),
            new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 10, 10)), 80000),
        };

            series.Points.AddRange(dataPoints);
            plotModel.Series.Add(series);
            plotView.Model = plotModel;
        }


    }
}
