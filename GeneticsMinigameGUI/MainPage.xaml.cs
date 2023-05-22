namespace GeneticsMinigameGUI;

/// <summary>
/// The GUI for the genetics minigame.
/// </summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// Sets up the main page.
	/// </summary>
	public MainPage()
	{
		InitializeComponent();
		this.SetWidths(null, null);
	}

    /// <summary>
    /// Sets the widths of the name entry and breed picker.
    /// </summary>
    /// <param name="sender">Unused, may be null.</param>
    /// <param name="args">Unused, may be null.</param>
    private void SetWidths(object sender, EventArgs args)
    {
        NameEntry.WidthRequest = this.Width - 100;
        BreedPicker.WidthRequest = this.Width - 100;
    }
}

