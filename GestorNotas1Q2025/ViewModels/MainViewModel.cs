using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GestorNotas1Q2025.Views;

namespace GestorNotas1Q2025.ViewModels
{
    public partial class MainViewModel:ObservableObject
    {
        [RelayCommand]
        private async Task GoToAddEditView()
        {
            await App.Current!.MainPage.Navigation.PushAsync(new AddEditView());
        }
    }
}
