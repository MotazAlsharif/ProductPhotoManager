using Microsoft.Maui.Controls;
using ProductPhotoManager.ViewModel;

namespace ProductPhotoManager
{
	public partial class MainPage : ContentPage
	{

		private PhotosViewModel _viewModel;
		public MainPage()
		{
			InitializeComponent();
			_viewModel = new PhotosViewModel();
			BindingContext = _viewModel;
		}
		private async void OnTakePhotoButtonClicked(object sender, EventArgs e)
		{

			var pictureTaker = new TakeaPicture();
			var photo = await pictureTaker.TakePhotoAsync();

			if (photo != null)
			{
				_viewModel.Photos!.Add(photo);
			}
		}


		private async void OnListClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new PhotoList(_viewModel));
		}
	}
}
