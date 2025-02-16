namespace MAUI_Controls;

public partial class InputControlsDemo : ContentPage
{
	public InputControlsDemo()
	{
		InitializeComponent();
	}

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		if (lblSlider != null)
		{
            lblSlider.Text = e.NewValue.ToString();
        }
    }

    private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if (lblSlider != null)
        {
            lblSlider.Text = e.NewValue.ToString();
        }
    }
}