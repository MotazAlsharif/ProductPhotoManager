using ProductPhotoManager.Model;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ProductPhotoManager.ViewModel
{
	internal class TakeaPicture
	{
		public async Task<PhotoModel> TakePhotoAsync()
		{
			try
			{
				var photo = await Microsoft.Maui.Media.MediaPicker.CapturePhotoAsync();
				if (photo == null)
					return null;

				var newFile = Path.Combine(Microsoft.Maui.Storage.FileSystem.AppDataDirectory, photo.FileName);
				using (var stream = await photo.OpenReadAsync())
				{
					using (var newStream = File.OpenWrite(newFile))
						await stream.CopyToAsync(newStream);

					return new PhotoModel(newFile);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"CapturePhotoAsync THREW: {ex.Message}");
				return null;
			}
		}

		public async void OnTakePhotoButtonClicked(object sender, EventArgs e)
		{
			var photo = await TakePhotoAsync();
			if (photo != null)
			{
				Console.WriteLine($"Photo captured: {photo.FilePath}");
			}
		}
	}
}
