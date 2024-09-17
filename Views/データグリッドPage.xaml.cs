﻿using Microsoft.UI.Xaml.Controls;

using アプリ1.ViewModels;

namespace アプリ1.Views;

// TODO: Change the grid as appropriate for your app. Adjust the column definitions on DataGridPage.xaml.
// For more details, see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid.
public sealed partial class データグリッドPage : Page
{
    public データグリッドViewModel ViewModel
    {
        get;
    }

    public データグリッドPage()
    {
        ViewModel = App.GetService<データグリッドViewModel>();
        InitializeComponent();
    }
}
