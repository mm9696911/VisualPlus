#region Namespace

using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;

using VisualPlus.Localization;
using VisualPlus.TypeConverters;
using VisualPlus.UITypeEditors;

#endregion

namespace VisualPlus.Structure
{
    /// <summary>The supported theme colors.</summary>
    public class ColorPalette
    {
        #region Properties

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color BackCircle { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color BorderHover { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color BorderNormal { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color CloseButtonBackDisabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color CloseButtonBackEnabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color CloseButtonBackHover { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color CloseButtonBackPressed { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color CloseButtonForeDisabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color CloseButtonForeEnabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color CloseButtonForeHover { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color CloseButtonForePressed { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color ColumnHeader { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color ColumnText { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color ControlDisabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color ControlEnabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color Disabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color ElementDisabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color ElementEnabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color Enabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color ForeCircle { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color FormBackground { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color FormWindowBar { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color HatchBackColor { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color HatchForeColor { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color HelpButtonBackDisabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color HelpButtonBackEnabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color HelpButtonBackHover { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color HelpButtonBackPressed { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color HelpButtonForeDisabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color HelpButtonForeEnabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color HelpButtonForeHover { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color HelpButtonForePressed { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color Hover { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color Item { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color ItemAlternate { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color ItemHover { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color ItemSelected { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color MaximizeButtonBackDisabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color MaximizeButtonBackEnabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color MaximizeButtonBackHover { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color MaximizeButtonBackPressed { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color MaximizeButtonForeDisabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color MaximizeButtonForeEnabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color MaximizeButtonForeHover { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color MaximizeButtonForePressed { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color MinimizeButtonBackDisabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color MinimizeButtonBackEnabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color MinimizeButtonBackHover { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color MinimizeButtonBackPressed { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color MinimizeButtonForeDisabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color MinimizeButtonForeEnabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color MinimizeButtonForeHover { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color MinimizeButtonForePressed { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color Pressed { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color Progress { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color ProgressBackground { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color ProgressDisabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color ScrollBarDisabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color ScrollBarEnabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color ScrollButtonDisabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color ScrollButtonEnabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color ScrollButtonHover { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color ScrollButtonPressed { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color ScrollThumbDisabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color ScrollThumbEnabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color ScrollThumbHover { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color ScrollThumbPressed { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color Selected { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color Star { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color StarBorder { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color StarDull { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color StarDullBorder { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color SubscriptColor { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color SuperscriptColor { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color TabPageDisabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color TabPageEnabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color TabPageHover { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color TabPageSelected { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color TextDisabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color TextEnabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color TextHover { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color TextLight { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color TextPressed { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color VisualComboBoxDisabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color VisualComboBoxEnabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color VisualSeparatorLine { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color VisualSeparatorShadow { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color WatermarkActive { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(VisualColorConverter))]
        public Color WatermarkInactive { get; set; }

        #endregion
    }
}