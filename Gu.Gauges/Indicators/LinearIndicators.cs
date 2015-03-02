﻿namespace Gu.Gauges
{
    using System.Collections.ObjectModel;
    using System.Windows;
    using System.Windows.Markup;

    [ContentProperty("Items")]
    public class LinearIndicators : Indicators<LinearGauge>
    {
        private static readonly DependencyPropertyKey ItemsPropertyKey = DependencyProperty.RegisterReadOnly(
            "Items",
            typeof(ObservableCollection<LinearIndicator>),
            typeof(LinearIndicators),
            new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty ItemsProperty = ItemsPropertyKey.DependencyProperty;

        private static readonly DependencyPropertyKey GaugePropertyKey = DependencyProperty.RegisterReadOnly(
            "Gauge",
            typeof(LinearGauge),
            typeof(LinearIndicators),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsArrange | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public static readonly DependencyProperty GaugeProperty = GaugePropertyKey.DependencyProperty;

        static LinearIndicators()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LinearIndicators), new FrameworkPropertyMetadata(typeof(LinearIndicators)));
        }

        public LinearIndicators()
        {
            this.Items = new ObservableCollection<LinearIndicator>();
        }

        public ObservableCollection<LinearIndicator> Items
        {
            get { return (ObservableCollection<LinearIndicator>)this.GetValue(ItemsProperty); }
            protected set { this.SetValue(ItemsPropertyKey, value); }
        }

        public LinearGauge Gauge
        {
            get { return (LinearGauge)this.GetValue(GaugeProperty); }
            protected set { this.SetValue(GaugePropertyKey, value); }
        }

        protected override void OnGaugeChanged(LinearGauge newGauge)
        {
            this.Gauge = newGauge;
        }
    }
}