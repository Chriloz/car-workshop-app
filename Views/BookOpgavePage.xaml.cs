using Bilvaerksted.ViewModels;

namespace Bilvaerksted.Views;

public partial class BookOpgavePage : ContentPage
{
	public BookOpgavePage(BookOpgaveViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}