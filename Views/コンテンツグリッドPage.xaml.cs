using Microsoft.UI.Xaml.Controls;

using アプリ1.ViewModels;

namespace アプリ1.Views;

public sealed partial class コンテンツグリッドPage : Page
{
    public コンテンツグリッドViewModel ViewModel
    {
        get;
    }

    public コンテンツグリッドPage()
    {
        ViewModel = App.GetService<コンテンツグリッドViewModel>();
        InitializeComponent();
    }
}
