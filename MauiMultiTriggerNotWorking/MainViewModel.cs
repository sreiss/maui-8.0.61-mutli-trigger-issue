using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiMultiTriggerNotWorking
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool _firstCondition = false;

        [ObservableProperty]
        private bool _secondCondition = true;
    }
}
