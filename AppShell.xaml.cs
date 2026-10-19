using Bilvaerksted.Views;

namespace Bilvaerksted;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(BookOpgavePage), typeof(BookOpgavePage));
		Routing.RegisterRoute(nameof(KalenderPage), typeof(KalenderPage));
		Routing.RegisterRoute(nameof(LavFakturaPage), typeof(LavFakturaPage));
		Routing.RegisterRoute(nameof(SeFakturaerPage), typeof(SeFakturaerPage));
	}
}
