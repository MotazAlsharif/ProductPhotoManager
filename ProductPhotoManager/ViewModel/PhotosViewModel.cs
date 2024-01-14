using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using ProductPhotoManager.Model;

namespace ProductPhotoManager.ViewModel
{
	public class PhotosViewModel : BindableObject
	{
		private ObservableCollection<PhotoModel> _photos = [];
		private PhotoModel? _selectedPhoto;

		public PhotosViewModel()
		{
			DeletePhotoCommand = new Command<PhotoModel>(DeletePhoto);
			AnnotatePhotoCommand = new Command<PhotoModel>(AnnotatePhoto);
		}
		public ICommand DeletePhotoCommand { get; }
		public ICommand AnnotatePhotoCommand { get; }

		public ObservableCollection<PhotoModel>? Photos
		{
			get { return _photos; }
			set
			{
				if (_photos != value)
				{
					_photos = value!;
					OnPropertyChanged(nameof(Photos));
				}
			}
		}

		public PhotoModel? SelectedPhoto
		{
			get { return _selectedPhoto; }
			set
			{
				if (_selectedPhoto != value)
				{
					_selectedPhoto = value;
					OnPropertyChanged(nameof(SelectedPhoto));
				}
			}
		}

		private void DeletePhoto(PhotoModel photo)
		{
			_photos.Remove(photo);
			Photos.Remove(photo);
		}

		private void AnnotatePhoto(PhotoModel photo)
		{
			_photos.FirstOrDefault(photo).Annotation = photo.Annotation;
		}
	}
}
