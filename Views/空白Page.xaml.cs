using Microsoft.UI.Xaml.Controls;

using アプリ1.ViewModels;

namespace アプリ1.Views;

public sealed partial class 空白Page : Page
{
    public 空白ViewModel ViewModel
    {
        get;
    }

    public 空白Page()
    {
        ViewModel = App.GetService<空白ViewModel>();
        InitializeComponent();
    }
}
