using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace WpfMvvmIssue;

[ObservableObject]
public partial record RecordTestViewModel
{
    [ObservableProperty]
    private string? _message;
}
