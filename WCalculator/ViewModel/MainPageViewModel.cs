using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCalculator.View;

namespace WCalculator.ViewModel
{
    public partial class MainPageViewModel : ObservableObject
    {
        [RelayCommand]
        async Task GoToCalculatorPage()
        {
            await Shell.Current.GoToAsync(nameof(CalculatorView));
        }
    }
}
