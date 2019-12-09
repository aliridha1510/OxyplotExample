using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;

namespace FDOXEXAMPLE
{


    class MainViewModel : ViewModelBase
    {

        private readonly Collection<ScatterPoint> _collectionOfScatterPoints = new Collection<ScatterPoint>
        {
            new ScatterPoint(12, 21),
            new ScatterPoint(40, 21),
            new ScatterPoint(55, 32),
            new ScatterPoint(80, 32),
            new ScatterPoint(60, 34),
            new ScatterPoint(90, 54),
            new ScatterPoint(100, 54),
            new ScatterPoint(40, 32),
            new ScatterPoint(20, 56),
            new ScatterPoint(120, 65),
            new ScatterPoint(50, 43),

        };
        public PlotModel Model { get; set; }

        public LinearAxis XAxis { get; private set; }
        public LinearAxis XAxis2 { get; private set; }
        public LinearAxis YAxis { get; private set; }
        public LinearAxis YAxis2 { get; private set; }






        public MainViewModel()
        {
            this.Model = new PlotModel() { PlotType = PlotType.Polar };
            Model.Title = "OXY";


            InitModel();

        }

        public void InitModel()
        {

            XAxis = new LinearAxis
            {
                Position = AxisPosition.Top,
                PositionTier = 0,
                AxislineStyle = LineStyle.Solid,
                Minimum = 0,
                AxislineColor = OxyColors.Red,
                StartPosition = 0.5,
                EndPosition = 1,
                PositionAtZeroCrossing = true,
                AbsoluteMinimum = 0,
                Title = "ABC",

            };
            Model.Axes.Add(XAxis);

            XAxis2 = new LinearAxis
            {
                Position = AxisPosition.Top,
                PositionTier = 0,
                AxislineStyle = LineStyle.Solid,
                Minimum = 0,
                AxislineColor = OxyColors.Gold,
                StartPosition = 0.5,
                EndPosition = 0,
                PositionAtZeroCrossing = true,
                IsAxisVisible = true,
                AbsoluteMinimum = 0,
                Title = "DCS",

            };
            Model.Axes.Add(XAxis2);
            YAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                AxislineStyle = LineStyle.Solid,
                Minimum = 0,
                AxislineColor = OxyColors.Green,
                PositionTier = 0,
                StartPosition = 0.5,
                EndPosition = 1,
                PositionAtZeroCrossing = true,
                AbsoluteMinimum = 0,
                AbsoluteMaximum = 1000,
                Title = "DSDC",

            };
            Model.Axes.Add(YAxis);
            YAxis2 = new LinearAxis
            {
                Position = AxisPosition.Right,
                AxislineStyle = LineStyle.Solid,
                Minimum = 0,
                AxislineColor = OxyColors.Violet,
                PositionTier = 0,
                StartPosition = 0.5,
                EndPosition = 0,
                PositionAtZeroCrossing = true,
                AbsoluteMinimum = 0,

            };
            Model.Axes.Add(YAxis2);
            Model.PlotAreaBorderThickness = new OxyThickness(1, 1, 1, 1);



        }
    }
}
