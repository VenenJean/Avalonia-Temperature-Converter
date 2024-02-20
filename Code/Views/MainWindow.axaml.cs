using System;
using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace FirstApp.Views;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
        #if DEBUG
        this.AttachDevTools();
        #endif
        Width = 400;
        Height = 550;
    }

    public void ButtonClicked(object source, RoutedEventArgs args) {
      Debug.WriteLine($"Click! Celsius={celsius.Text}");

      if (double.TryParse(celsius.Text, out var C)) {
        var F = C * (9d / 5d) + 32;
        fahrenheit.Text = F.ToString("0.0");
      } else {
        celsius.Text = "0";
        fahrenheit.Text = "0";
      }
    }

    private void Celsius_OnTextChanged(object source, TextChangedEventArgs args) {
      if (double.TryParse(celsius.Text, out var C)) {
        var F = C * (9d / 5d) + 32;
        fahrenheit.Text = F.ToString("0.0");
      } else {
        celsius.Text = "0";
        fahrenheit.Text = "0";
      }
    }
}