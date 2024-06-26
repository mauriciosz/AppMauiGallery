namespace AppMAUIGalery.Views.Components.Mains;

public partial class ImageButtonPage : ContentPage
{
	bool buttonState = false;
	public ImageButtonPage()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		buttonState = !buttonState;

		var powerOff = "poweroff.png";
		var powerOn = "poweron.png";

		var button = (ImageButton)sender;

		/* poderia fazer um if direto, mas vou deixar 3 ternários aqui */
		button.Source = (buttonState == false ? ImageSource.FromFile(powerOff) : ImageSource.FromFile(powerOn));
		lblSituacao.Text = (buttonState == false) ? "Desligado - OFF" : "Ligado - ON";
		imgCarrinho.RotationY = (buttonState == false) ? 0 : 180;
    }
}