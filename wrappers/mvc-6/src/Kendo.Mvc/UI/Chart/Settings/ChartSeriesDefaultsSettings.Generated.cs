using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Defines the Chart series defaults settings
    /// </summary>
    public partial class ChartSeriesDefaultsSettings<T> where T : class
    {

        /// <summary>
        /// The Area series default settings.
        /// </summary>
        public ChartSeries<T> Area { get; } = new ChartSeries<T>();

        /// <summary>
        /// The Bar series default settings.
        /// </summary>
        public ChartSeries<T> Bar { get; } = new ChartSeries<T>();

        /// <summary>
        /// The Bubble series default settings.
        /// </summary>
        public ChartSeries<T> Bubble { get; } = new ChartSeries<T>();

        /// <summary>
        /// The Bullet series default settings.
        /// </summary>
        public ChartSeries<T> Bullet { get; } = new ChartSeries<T>();

        /// <summary>
        /// The Candlestick series default settings.
        /// </summary>
        public ChartSeries<T> Candlestick { get; } = new ChartSeries<T>();

        /// <summary>
        /// The Column series default settings.
        /// </summary>
        public ChartSeries<T> Column { get; } = new ChartSeries<T>();

        /// <summary>
        /// The Donut series default settings.
        /// </summary>
        public ChartSeries<T> Donut { get; } = new ChartSeries<T>();

        /// <summary>
        /// The Line series default settings.
        /// </summary>
        public ChartSeries<T> Line { get; } = new ChartSeries<T>();

        /// <summary>
        /// The Pie series default settings.
        /// </summary>
        public ChartSeries<T> Pie { get; } = new ChartSeries<T>();

        /// <summary>
        /// The Scatter series default settings.
        /// </summary>
        public ChartSeries<T> Scatter { get; } = new ChartSeries<T>();

        /// <summary>
        /// The ScatterLine series default settings.
        /// </summary>
        public ChartSeries<T> ScatterLine { get; } = new ChartSeries<T>();

        /// <summary>
        /// The VerticalBullet series default settings.
        /// </summary>
        public ChartSeries<T> VerticalBullet { get; } = new ChartSeries<T>();

        public IDictionary<string, object> Serialize()
        {
            var settings = new Dictionary<string, object>();

            var area = Area.Serialize();

            if (area.Any())
            {
                settings["area"] = area;
            }

            var bar = Bar.Serialize();

            if (bar.Any())
            {
                settings["bar"] = bar;
            }

            var bubble = Bubble.Serialize();

            if (bubble.Any())
            {
                settings["bubble"] = bubble;
            }

            var bullet = Bullet.Serialize();

            if (bullet.Any())
            {
                settings["bullet"] = bullet;
            }

            var candlestick = Candlestick.Serialize();

            if (candlestick.Any())
            {
                settings["candlestick"] = candlestick;
            }

            var column = Column.Serialize();

            if (column.Any())
            {
                settings["column"] = column;
            }

            var donut = Donut.Serialize();

            if (donut.Any())
            {
                settings["donut"] = donut;
            }

            var line = Line.Serialize();

            if (line.Any())
            {
                settings["line"] = line;
            }

            var pie = Pie.Serialize();

            if (pie.Any())
            {
                settings["pie"] = pie;
            }

            var scatter = Scatter.Serialize();

            if (scatter.Any())
            {
                settings["scatter"] = scatter;
            }

            var scatterLine = ScatterLine.Serialize();

            if (scatterLine.Any())
            {
                settings["scatterLine"] = scatterLine;
            }

            var verticalBullet = VerticalBullet.Serialize();

            if (verticalBullet.Any())
            {
                settings["verticalBullet"] = verticalBullet;
            }

            return settings;
        }
    }
}
