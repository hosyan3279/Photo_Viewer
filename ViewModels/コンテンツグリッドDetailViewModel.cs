using CommunityToolkit.Mvvm.ComponentModel;

using アプリ1.Contracts.ViewModels;
using アプリ1.Core.Contracts.Services;
using アプリ1.Core.Models;

namespace アプリ1.ViewModels;

public partial class コンテンツグリッドDetailViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    [ObservableProperty]
    private SampleOrder? item;

    public コンテンツグリッドDetailViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        if (parameter is long orderID)
        {
            var data = await _sampleDataService.GetContentGridDataAsync();
            Item = data.First(i => i.OrderID == orderID);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
