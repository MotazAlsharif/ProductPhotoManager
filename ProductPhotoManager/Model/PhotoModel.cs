using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPhotoManager.Model
{
	public class PhotoModel(string filePath)
	{
		//private readonly List<PhotoModel> _photos = [];

		public string FilePath { get; set; } = filePath;
		public string Annotation { get; set; } = "";

		//public async Task TakeAndStorePhotoAsync()
		//{
		//	var photoResult = await MediaPicker.CapturePhotoAsync();
		//	if (photoResult != null)
		//	{
		//		var newFile = Path.Combine(FileSystem.AppDataDirectory, photoResult.FileName);

		//		using var stream = await photoResult.OpenReadAsync();
		//		using (var newStream = File.OpenWrite(newFile))
		//			await stream.CopyToAsync(newStream);

		//		var photo = new PhotoModel(newFile);
		//		_photos.Add(photo);
		//	}
		//}
		//zzpublic void DeletePhoto(PhotoModel photo)
		//{
		//	_photos.Remove(photo);

		//	File.Delete(photo.FilePath);
		//}
		//public void AnnotatePhoto(PhotoModel photo, string annotation)
		//{
		//	photo.Annotation = annotation;
		//}

	}
}
