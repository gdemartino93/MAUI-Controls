using System.Diagnostics;

namespace MAUI_Controls;

public partial class CollectionsControlsDemo : ContentPage
{
	public CollectionsControlsDemo()
	{
		InitializeComponent();
	}

    private void txtName_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void txtName_Completed(object sender, EventArgs e)
    {
        Debug.WriteLine(txtName.Text);
    }
}