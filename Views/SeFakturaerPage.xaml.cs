using Bilvaerksted.ViewModels;

namespace Bilvaerksted.Views;

public partial class SeFakturaerPage : ContentPage
{
	public SeFakturaerPage(SeFakturaerViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
