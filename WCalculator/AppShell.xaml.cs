using WCalculator.View;

namespace WCalculator;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(CalculatorView), typeof(CalculatorView));
	}
}
