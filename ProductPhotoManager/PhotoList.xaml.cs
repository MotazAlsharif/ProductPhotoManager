using ProductPhotoManager.ViewModel;

namespace ProductPhotoManager;

public partial class PhotoList : ContentPage
{
	private readonly PhotosViewModel _viewModel;

	public PhotoList(PhotosViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		BindingContext = _viewModel;
	}
	private async void OnCloseClickedAsync(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}