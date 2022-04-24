# Avalonia Demo

This project demonstrates how to use the MVVM pattern in Avalonia without the need of code-behind files.

The concept is to define your Views as DataTemplates and then dynamically load them at runtime using the custom ``DataTemplateLocator`` which is registered in the `App.axaml`.
The logic can be adapted based on your folder structure, i.e. in a larger project you might want to group views of certain parts of the application in subfolders.