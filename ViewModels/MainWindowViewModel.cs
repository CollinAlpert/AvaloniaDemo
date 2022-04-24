namespace AvaloniaDemo.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
	public Area1ViewModel Area1 { get; } = new();
	
	public Area2ViewModel Area2 { get; } = new();
}