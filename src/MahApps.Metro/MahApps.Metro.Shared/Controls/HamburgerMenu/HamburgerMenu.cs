﻿namespace MahApps.Metro.Controls
{
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// The HamburgerMenu is based on a SplitView control. By default it contains a HamburgerButton and a ListView to display menu items.
    /// </summary>
    [TemplatePart(Name = "HamburgerButton", Type = typeof(Button))]
    [TemplatePart(Name = "ButtonsListView", Type = typeof(ListBox))]
    [TemplatePart(Name = "OptionsListView", Type = typeof(ListBox))]
    public partial class HamburgerMenu : ContentControl
    {
        private Button _hamburgerButton;
        private ListBox _buttonsListView;
        private ListBox _optionsListView;

        /// <summary>
        /// Initializes a new instance of the <see cref="HamburgerMenu"/> class.
        /// </summary>
        public HamburgerMenu()
        {
            DefaultStyleKey = typeof(HamburgerMenu);
        }

        /// <summary>
        /// Override default OnApplyTemplate to capture children controls
        /// </summary>
        public override void OnApplyTemplate()
        {
            if (_hamburgerButton != null)
            {
                _hamburgerButton.Click -= HamburgerButton_Click;
            }

            if (_buttonsListView != null)
            {
                _buttonsListView.MouseUp -= ButtonsListView_ItemClick;
            }

            if (_optionsListView != null)
            {
                _optionsListView.MouseUp -= OptionsListView_ItemClick;
            }

            _hamburgerButton = (Button)GetTemplateChild("HamburgerButton");
            _buttonsListView = (ListBox)GetTemplateChild("ButtonsListView");
            _optionsListView = (ListBox)GetTemplateChild("OptionsListView");

            if (_hamburgerButton != null)
            {
                _hamburgerButton.Click += HamburgerButton_Click;
            }

            if (_buttonsListView != null)
            {
                _buttonsListView.MouseUp += ButtonsListView_ItemClick;
            }

            if (_optionsListView != null)
            {
                _optionsListView.MouseUp += OptionsListView_ItemClick;
            }

            this.Loaded -= HamburgerMenu_Loaded;
            this.Loaded += HamburgerMenu_Loaded;

            base.OnApplyTemplate();
        }

        private void HamburgerMenu_Loaded(object sender, RoutedEventArgs e)
        {
			// The below prevents in-line content (a bug)
           // this.SetCurrentValue(ContentProperty, _buttonsListView?.SelectedItem ?? _optionsListView?.SelectedItem);//
        }
    }
}
