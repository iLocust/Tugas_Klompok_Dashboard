using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;

namespace Dashboard
{
    public partial class diagram : UserControl
    {
        public diagram()
        {
            InitializeComponent();
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,10),      //First Point of First Line
                        new ObservablePoint(2,7),       //2nd POint
                        new ObservablePoint(4,3),     //------
                        new ObservablePoint(6,6),
                        new ObservablePoint(8,8),
                        new ObservablePoint(10,9)
                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,2),      //First Point of 2nd Line
                        new ObservablePoint(2,5),       //2nd POint
                        new ObservablePoint(4,6),     //------
                        new ObservablePoint(6,8),
                        new ObservablePoint(8,5),
                        new ObservablePoint(10,6)
                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,4),      //First Point of 3rd Line
                        new ObservablePoint(2,5),       //2nd POint
                        new ObservablePoint(4,7),     //------
                        new ObservablePoint(6,10),
                        new ObservablePoint(8,9),
                        new ObservablePoint(10,11)
                    },
                    PointGeometrySize = 15
                }
            };
        }
    }
}
