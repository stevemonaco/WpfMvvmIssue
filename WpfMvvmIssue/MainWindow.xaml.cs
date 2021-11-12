using System.Windows;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace WpfMvvmIssue;

[ObservableObject]
public partial class MainWindow : Window
{
    [ObservableProperty]
    private string? _message = "TestingWindowMessage";

    private RecordTestViewModel _recordVM = new();
    private ClassTestViewModel _classVM = new() { Message = "TestingClassMessage" };

    public MainWindow()
    {
        InitializeComponent();
        //DataContext = _recordVM;
        DataContext = _classVM;
        //DataContext = this;
    }

    public void OnLoad(object sender, RoutedEventArgs e)
    {
        //_recordVM.Message += ": INPC Changed!";
        _classVM.Message += ": INPC Changed!";
        //Message += ": INPC Changed!";
    }
}