﻿using CommunityToolkit.WinUI.UI.Controls;

using Microsoft.UI.Xaml.Controls;

using アプリ1.ViewModels;

namespace アプリ1.Views;

public sealed partial class 詳細を一覧表示Page : Page
{
    public 詳細を一覧表示ViewModel ViewModel
    {
        get;
    }

    public 詳細を一覧表示Page()
    {
        ViewModel = App.GetService<詳細を一覧表示ViewModel>();
        InitializeComponent();
    }

    private void OnViewStateChanged(object sender, ListDetailsViewState e)
    {
        if (e == ListDetailsViewState.Both)
        {
            ViewModel.EnsureItemSelected();
        }
    }
}
