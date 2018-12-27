﻿using GnsDesktopManager.Model;
using System;
using System.Windows;
using Tick42.StickyWindows;

namespace Notifications
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RaiseButton.Click += RaiseButton_Click;
            RegisterToStickyWindows();
        }

        private void RegisterToStickyWindows()
        {
            // 1. Try to get startup options passed from GD
            // Create our default options if there aren't any passed options
            // Make your app a sticky flat window with title Notifications

            var bounds = new SwBounds
            {
                Width = 300,
                Height = 190
            };
            var placement = new SwScreenPlacement();
            placement.WithBounds(bounds);
            var id = Guid.NewGuid().ToString();
        }

        private void RaiseButton_Click(object sender, RoutedEventArgs e)
        {
            // 4.1 Raise a notification here
            // 4.2 The notification should invoke the method registered in the Clients application which opens the Contact Info
        }
    }
}
