using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace WpfMvvmIssue;

[ObservableObject]
public partial class MainViewModel
{
    [ObservableProperty]
    private string? _name;
}
