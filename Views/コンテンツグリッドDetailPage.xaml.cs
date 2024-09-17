﻿using CommunityToolkit.WinUI.UI.Animations;

using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

using アプリ1.Contracts.Services;
using アプリ1.ViewModels;

namespace アプリ1.Views;

public sealed partial class コンテンツグリッドDetailPage : Page
{
    public コンテンツグリッドDetailViewModel ViewModel
    {
        get;
    }

    public コンテンツグリッドDetailPage()
    {
        ViewModel = App.GetService<コンテンツグリッドDetailViewModel>();
        InitializeComponent();
    }

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);
        this.RegisterElementForConnectedAnimation("animationKeyContentGrid", itemHero);
    }

    protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
    {
        base.OnNavigatingFrom(e);
        if (e.NavigationMode == NavigationMode.Back)
        {
            var navigationService = App.GetService<INavigationService>();

            if (ViewModel.Item != null)
            {
                navigationService.SetListDataItemForNextConnectedAnimation(ViewModel.Item);
            }
        }
    }
}
