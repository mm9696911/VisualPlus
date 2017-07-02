﻿namespace VisualPlus.Controls.Bases
{
    #region Namespace

    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Text;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    using VisualPlus.Framework;
    using VisualPlus.Framework.Structure;
    using VisualPlus.Styles;

    #endregion

    [ToolboxItem(false)]
    [DesignerCategory("code")]
    [ClassInterface(ClassInterfaceType.AutoDispatch)]
    [ComVisible(true)]
    public abstract class ControlBase : Control
    {
        #region Variables

        private readonly MouseState mouseState;
        private Color foreColorDisabled;
        private StyleManager styleManager;
        private TextRenderingHint textRendererHint;

        #endregion

        #region Constructors

        protected ControlBase()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);

            // DoubleBuffered = true;
            mouseState = new MouseState(this);
            foreColorDisabled = Settings.DefaultValue.Font.ForeColorDisabled;
            styleManager = new StyleManager();
            textRendererHint = Settings.DefaultValue.TextRenderingHint;
        }

        public delegate void ForeColorDisabledChangedEventHandler();

        public delegate void MouseStateChangedEventHandler();

        public delegate void StyleManagerChangedEventHandler();

        public delegate void TextRenderingChangedEventHandler();

        [Category(Localize.EventsCategory.PropertyChanged)]
        public event ForeColorDisabledChangedEventHandler ForeColorDisabledChanged;

        [Category(Localize.EventsCategory.Mouse)]
        public event MouseStateChangedEventHandler MouseStateChanged;

        [Category(Localize.EventsCategory.Appearance)]
        public event StyleManagerChangedEventHandler StyleManagerChanged;

        [Category(Localize.EventsCategory.PropertyChanged)]
        public event TextRenderingChangedEventHandler TextRenderingHintChanged;

        #endregion

        #region Properties

        [Category(Localize.PropertiesCategory.Appearance)]
        [Description(Localize.Description.Common.Color)]
        public Color ForeColorDisabled
        {
            get
            {
                return foreColorDisabled;
            }

            set
            {
                foreColorDisabled = value;
                OnForeColorDisabledChanged();
                Invalidate();
            }
        }

        [Category(Localize.PropertiesCategory.Appearance)]
        [Description(Localize.Description.Common.MouseState)]
        public MouseStates MouseState
        {
            get
            {
                return mouseState.State;
            }

            set
            {
                mouseState.State = value;
                OnMouseStateChanged();
                Invalidate();
            }
        }

        [TypeConverter(typeof(StyleManagerConverter))]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Category(Localize.PropertiesCategory.Appearance)]
        public StyleManager StyleManager
        {
            get
            {
                return styleManager;
            }

            set
            {
                styleManager = value;
                Invalidate();
                OnStyleManagerChanged();
            }
        }

        [Category(Localize.PropertiesCategory.Appearance)]
        [Description(Localize.Description.Strings.TextRenderingHint)]
        public TextRenderingHint TextRenderingHint
        {
            get
            {
                return textRendererHint;
            }

            set
            {
                textRendererHint = value;
                OnTextRenderingHintChanged();
                Invalidate();
            }
        }

        #endregion

        #region Events

        protected virtual void OnForeColorDisabledChanged()
        {
            ForeColorDisabledChanged?.Invoke();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            MouseState = MouseStates.Down;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseState = MouseStates.Hover;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MouseState = MouseStates.Normal;
        }

        protected virtual void OnMouseStateChanged()
        {
            MouseStateChanged?.Invoke();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            MouseState = MouseStates.Hover;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.Clear(Parent.BackColor);
            graphics.FillRectangle(new SolidBrush(BackColor), ClientRectangle);
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.TextRenderingHint = textRendererHint;

            InitializeTheme();

            ForeColor = Enabled ? ForeColor : ForeColorDisabled;
        }

        private void InitializeTheme()
        {
            if (StyleManager.LockedStyle)
            {
                if (StyleManager.VisualStylesManager != null)
                {
                    IFont fontStyle = StyleManager.VisualStylesManager.FontStyle;

                    Font = new Font(fontStyle.FontFamily, fontStyle.FontSize, fontStyle.FontStyle);
                    ForeColor = fontStyle.ForeColor;
                    foreColorDisabled = fontStyle.ForeColorDisabled;
                }
                else
                {
                    Font = Settings.DefaultValue.DefaultFont;
                    ForeColor = Settings.DefaultValue.Font.ForeColor;
                    foreColorDisabled = Settings.DefaultValue.Font.ForeColorDisabled;
                }
            }
        }

        /// <summary>Fires the OnStyleManagerChanged event.</summary>
        protected virtual void OnStyleManagerChanged()
        {
            StyleManagerChanged?.Invoke();
        }

        /// <summary>Fires the OnTextRenderingHintChanged event.</summary>
        protected virtual void OnTextRenderingHintChanged()
        {
            TextRenderingHintChanged?.Invoke();
        }

        #endregion
    }
}