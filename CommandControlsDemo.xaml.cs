namespace MAUI_Controls;

public partial class CommandControlsDemo : ContentPage
{
	public CommandControlsDemo()
	{
		InitializeComponent();
	}

    private void btnSave_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Title test", "message test", "Confirm");
    }

    private void RadioBtn_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        DisplayAlert("Test title", $"changed: {e.Value}", "Confirm");
    }

    private void searchControl_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("Test title", $"changed: {searchControl.Text}", "Confirm");
    }

    private void SwipeItemSave_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Test title", "operazione conferamta", "ok");
    }

    private void SwipeItemDiscard_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Test title", "operazione annullata", "ok");
    }
}