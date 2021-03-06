﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FancySaiEditor
{
    /// <summary>
    /// Interaktionslogik für SAIImport.xaml
    /// </summary>
    public partial class SAIImport
    {
        public SAIImport()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ImportSAI();
        }

        private void entry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                ImportSAI();
        }

        private void ImportSAI()
        {
            try
            {
                SAIImporter.ImportSAI(Convert.ToInt32(entry.Text));
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show($"Entry {entry.Text} is not a valid entry!");
            }
        }

        private void entry_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            try
            {
                Convert.ToInt32(e.Text);
            }
            catch(FormatException)
            {
                e.Handled = true;
            }
        }
    }
}
