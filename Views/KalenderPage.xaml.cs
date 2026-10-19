using Bilvaerksted.ViewModels;

namespace Bilvaerksted.Views;

public partial class KalenderPage : ContentPage
{
	public KalenderPage(KalenderViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
