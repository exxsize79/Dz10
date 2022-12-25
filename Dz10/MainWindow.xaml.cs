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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dz10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void TextBox_TextInput(object sender, TextCompositionEventArgs e)
        {
            textBlock1.Text += e.Text;
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            textBlock1.Text += e.Key.ToString();
            if (e.Key == Key.OemQuotes)
                textBlock1.Text += "'"; // добавляем кавычки
            else
                textBlock1.Text += e.Key.ToString();
            if (e.KeyboardDevice.Modifiers.HasFlag(ModifierKeys.Shift) && e.Key == Key.F1)
                MessageBox.Show("HELLO");
        }
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (!Int32.TryParse(e.Text, out val) && e.Text != "-")
            {
                e.Handled = true; // отклоняем ввод
            }
        }
        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true; // если пробел, отклоняем ввод
            }
        }
    }
}
