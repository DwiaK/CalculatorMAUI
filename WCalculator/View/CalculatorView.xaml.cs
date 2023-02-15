using WCalculator.ViewModel;

namespace WCalculator.View;

public partial class CalculatorView : ContentPage
{
	public CalculatorView(CalculatorViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}