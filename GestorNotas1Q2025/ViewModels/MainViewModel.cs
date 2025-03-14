
using GestorNotas1Q2025.Views;

namespace GestorNotas1Q2025.ViewModels
{
    public partial class MainViewModel: ObservableObject
    {
        [RelayCommand]
        private async Task GoToAddEditView()
        {
            await App.Current!.MainPage!.Navigation.PushAsync(new AddEditView());
        }
    }
}
