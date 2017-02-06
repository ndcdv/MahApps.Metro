namespace MahApps.Metro.Controls
{
	using System.Windows;
	using System.Windows.Media;
	/// <summary>
	/// The HamburgerMenuItem provides a glyph based implementation for HamburgerMenu entries.
	/// </summary>
	public class HamburgerMenuGeometryItem : HamburgerMenuItem
    {
		/// <summary>
		/// Identifies the <see cref="GeometryData"/> dependency property.
		/// </summary>
		public static readonly DependencyProperty GeometryDataProperty = DependencyProperty.Register(nameof(Geometry), typeof(Geometry), typeof(HamburgerMenuItem), new PropertyMetadata(null));

        /// <summary>
        /// Gets or sets gets of sets a value that specifies the Geometry to use for a Path
        /// </summary>
        public Geometry GeometryData
		{
            get
            {
                return (Geometry)GetValue(GeometryDataProperty);
            }

            set
            {
                SetValue(GeometryDataProperty, value);
            }
        }
    }
}
