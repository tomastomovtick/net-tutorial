﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using Tick42.Windows;

namespace Contacts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RegisterToStickyWindows();
            ContactInfoGrid.ItemsSource = GetContacts();
        }

        private void RegisterToStickyWindows()
        {
            // 1. Try to get startup options passed from GD
            // Create our default options if there aren't any passed options
            // Make your app a sticky flat window with title Contacts

            var bounds = new GlueWindowBounds
            {
                Width = 800,
                Height = 450
            };
            var placement = new GlueWindowScreenPlacement();
            placement.WithBounds(bounds);
            var id = Guid.NewGuid().ToString();
        }

        private IEnumerable<ContactInfo> GetContacts()
        {
            IEnumerable<ContactInfo> contacts = new ObservableCollection<ContactInfo>();
            // 5 Invoke the FindWhoToCall method and use the returned value to populate the grid
            return contacts;
        }

    }
}
