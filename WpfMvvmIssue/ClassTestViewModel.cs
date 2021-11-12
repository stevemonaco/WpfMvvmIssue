using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace WpfMvvmIssue;

[ObservableObject]
public partial class ClassTestViewModel
{
    [ObservableProperty]
    private string? _message;
}
