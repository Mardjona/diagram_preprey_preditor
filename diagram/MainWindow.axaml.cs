using Avalonia.Controls;
using Avalonia.Controls;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Drawing.Geometries;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace diagram;

public partial class MainWindow : Window
{
    private static DiagramPredPrey _predPrey = new DiagramPredPrey(0.023, 0.3, 0.9,0.0012, 500, 75, 400, 40, 500, 70);

    public MainWindow()
    {
        InitializeComponent();
        ModelPreditorPrey.DataContext = _predPrey;
    }
    private void TextBox_KeyUp(object? sender, Avalonia.Input.KeyEventArgs e)
    {
        try
        {
            DiagramPredPrey diagramPredPrey = new DiagramPredPrey
            (
                Convert.ToDouble(Textbox_alfa.Text), 
                Convert.ToDouble(Textbox_beta.Text),
                Convert.ToDouble(Textbox_epsilon.Text), 
                Convert.ToDouble(Textbox_omega.Text),
                Convert.ToDouble(TextBox_GenPrey1.Text), 
                Convert.ToDouble(TextBox_GenPreditor1.Text),
                Convert.ToDouble(TextBox_GenPrey2.Text), 
                Convert.ToDouble(TextBox_GenPreditor2.Text),
                Convert.ToDouble(TextBox_GenPrey3.Text),
                Convert.ToDouble(TextBox_GenPreditor3.Text)
            );
            ModelPreditorPrey.DataContext = diagramPredPrey;
               
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Processing is cancelled.");
        }
    }
}