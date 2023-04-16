
using MauiLibraryWithAsync.Services.PartialMethods;
using MauiLibTest.Services.PartialMethods;

namespace MauiLibTest;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
    {
	    //over Lib
		var dsLib = new DelayLibService();
		await dsLib.DelayLibWithDummyReturnAsync(100);
		dsLib.DelayLibWithDummyReturn(100);

        //direct in the main project 
		var ds = new DelayService();
        await ds.DelayWithDummyReturnAsync(500);
        ds.DelayWithDummyReturn(500);

        count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

