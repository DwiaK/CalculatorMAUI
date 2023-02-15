namespace WCalculator.Controls;

public partial class ButtonControl : ContentView
{
	public static readonly BindableProperty TextProperty = BindableProperty.Create(
		nameof(Title), 
		typeof(string), 
		typeof(ButtonControl),
		propertyChanged: (bindable, oldValue, newValue) =>
		{
			var control = (ButtonControl)bindable;

			control.Text.Text = newValue as string;
		});

	public static readonly BindableProperty ImageProperty = BindableProperty.Create(
		nameof(ImgSource),
		typeof(string),
		typeof(ButtonControl),
		propertyChanged: (bindable, oldValue, newValue) =>
		{
			var control = (ButtonControl)bindable;
			control.Text.ImageSource = newValue as string;
		});

	public ButtonControl()
	{
		InitializeComponent();
	}

	public string Title
	{
		get => GetValue(TextProperty) as string;
		set => SetValue(TextProperty, value);
	}

	public string ImgSource
    {
		get => GetValue(ImageProperty) as string;
		set => SetValue(ImageProperty, value);
	}
}