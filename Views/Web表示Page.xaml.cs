﻿using Microsoft.UI.Xaml.Controls;

using アプリ1.ViewModels;

namespace アプリ1.Views;

// To learn more about WebView2, see https://docs.microsoft.com/microsoft-edge/webview2/.
public sealed partial class Web表示Page : Page
{
    public Web表示ViewModel ViewModel
    {
        get;
    }

    public Web表示Page()
    {
        ViewModel = App.GetService<Web表示ViewModel>();
        InitializeComponent();

        ViewModel.WebViewService.Initialize(WebView);
    }
}
