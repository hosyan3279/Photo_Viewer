using Microsoft.UI.Xaml.Controls;

using アプリ1.ViewModels;

namespace アプリ1.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
