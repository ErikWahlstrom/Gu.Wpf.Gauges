namespace Gu.Wpf.Gauges
{
    using System.Windows;

    public class AngularBar : TickBarBase
    {
#pragma warning disable SA1202 // Elements must be ordered by access
        private static readonly DependencyPropertyKey DiameterPropertyKey = DependencyProperty.RegisterReadOnly(
            nameof(Diameter),
            typeof(double),
            typeof(AngularBar),
            new PropertyMetadata(default(double)));

        public static readonly DependencyProperty DiameterProperty = DiameterPropertyKey.DependencyProperty;

        public static readonly DependencyProperty MinAngleProperty = AngularGauge.MinAngleProperty.AddOwner(
            typeof(AngularBar),
            new FrameworkPropertyMetadata(
                -180.0,
                FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.Inherits));

        public static readonly DependencyProperty MaxAngleProperty = AngularGauge.MaxAngleProperty.AddOwner(
            typeof(AngularBar),
            new FrameworkPropertyMetadata(
                0.0,
                FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.Inherits));
#pragma warning restore SA1202 // Elements must be ordered by access

        /// <summary>
        /// Gets or sets the effective diameter ie ActualWidth - ReservedSpace
        /// The default is -180
        /// </summary>
        public double Diameter
        {
            get => (double)this.GetValue(DiameterProperty);
            protected set => this.SetValue(DiameterPropertyKey, value);
        }

        /// <summary>
        /// Gets or sets the <see cref="P:AngularBar.MinAngle" />
        /// The default is -180
        /// </summary>
        public double MinAngle
        {
            get => (double)this.GetValue(MinAngleProperty);
            set => this.SetValue(MinAngleProperty, value);
        }

        /// <summary>
        /// Gets or sets the <see cref="P:AngularBar.MaxAngle" />
        /// The default is 0
        /// </summary>
        public double MaxAngle
        {
            get => (double)this.GetValue(MaxAngleProperty);
            set => this.SetValue(MaxAngleProperty, value);
        }
    }
}