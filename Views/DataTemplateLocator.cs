using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Markup.Xaml;
using Avalonia.Markup.Xaml.Templates;
using AvaloniaDemo.ViewModels;

namespace AvaloniaDemo.Views;

public class DataTemplateLocator : IDataTemplate
{
	private const string UriPlaceholder = "avares://AvaloniaDemo/Views/{0}.axaml";

	public IControl Build(object param)
	{
		var type = param.GetType();
		var viewName = type.Name.Replace("ViewModel", "View");
		var uriString = string.Format(UriPlaceholder, viewName);
		var dataTemplate = (DataTemplate)AvaloniaXamlLoader.Load(new Uri(uriString));

		return dataTemplate.Build(param);
	}

	public bool Match(object data)
	{
		return data is ViewModelBase;
	}
}