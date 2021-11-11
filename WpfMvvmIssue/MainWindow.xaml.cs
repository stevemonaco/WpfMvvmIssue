using System.Windows;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace WpfMvvmIssue;

[ObservableObject]
public partial class MainWindow : Window
{
    [ObservableProperty]
    private string? _name;

    public MainWindow()
    {
        _name = "Testing456";

        InitializeComponent();
        //DataContext = new MainViewModel() { Name = "Testing456" };
        DataContext = this;
    }
}
