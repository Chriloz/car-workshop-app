using Bilvaerksted.ViewModels;

namespace Bilvaerksted.Views;

public partial class LavFakturaPage : ContentPage
{
	public LavFakturaPage(LavFakturaViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
