using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCalculator.ViewModel
{
    public partial class CalculatorViewModel : ObservableObject
    {
        private int[] numbers;

        [RelayCommand]
        public void AddNumber()
        {

        }
    }
}
