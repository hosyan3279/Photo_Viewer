﻿using CommunityToolkit.Mvvm.ComponentModel;

using Microsoft.UI.Xaml.Controls;

using アプリ1.Contracts.Services;
using アプリ1.ViewModels;
using アプリ1.Views;

namespace アプリ1.Services;

public class PageService : IPageService
{
    private readonly Dictionary<string, Type> _pages = new();

    public PageService()
    {
        Configure<MainViewModel, MainPage>();
        Configure<空白ViewModel, 空白Page>();
        Configure<Web表示ViewModel, Web表示Page>();
        Configure<コンテンツグリッドViewModel, コンテンツグリッドPage>();
        Configure<コンテンツグリッドDetailViewModel, コンテンツグリッドDetailPage>();
        Configure<詳細を一覧表示ViewModel, 詳細を一覧表示Page>();
        Configure<データグリッドViewModel, データグリッドPage>();
        Configure<SettingsViewModel, SettingsPage>();
    }

    public Type GetPageType(string key)
    {
        Type? pageType;
        lock (_pages)
        {
            if (!_pages.TryGetValue(key, out pageType))
            {
                throw new ArgumentException($"Page not found: {key}. Did you forget to call PageService.Configure?");
            }
        }

        return pageType;
    }

    private void Configure<VM, V>()
        where VM : ObservableObject
        where V : Page
    {
        lock (_pages)
        {
            var key = typeof(VM).FullName!;
            if (_pages.ContainsKey(key))
            {
                throw new ArgumentException($"The key {key} is already configured in PageService");
            }

            var type = typeof(V);
            if (_pages.ContainsValue(type))
            {
                throw new ArgumentException($"This type is already configured with key {_pages.First(p => p.Value == type).Key}");
            }

            _pages.Add(key, type);
        }
    }
}
