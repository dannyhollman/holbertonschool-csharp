using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

/// <summary> ImageProcessor class </summary>
class ImageProcessor
{
	/// <summary> Invert image colors </summary>
	public static void Inverse(string[] filenames)
	{
		Color oldColor, newColor;
		foreach (string filename in filenames)
		{
			Bitmap image = (Bitmap) Image.FromFile(filename);

			for (int i = 0; i < image.Width; i++)
			{
				for (int j = 0; j < image.Height; j++)
				{
					oldColor = image.GetPixel(i, j);
					newColor = Color.FromArgb(255 - oldColor.R, 255 - oldColor.G, 255 - oldColor.B);
					image.SetPixel(i, j, newColor);
				}
			}
			string[] split = filename.Split('.', '/');
			string newFilename = split[split.Length - 2] + "_inverse." + split[split.Length - 1];
			image.Save(newFilename);
		}
	}
	/// <summary> Convert image to grayscale </summary>
	public static void Grayscale(string[] filenames)
	{
		Color oldColor;
		
		foreach (string filename in filenames)
		{
			Bitmap image = (Bitmap) Image.FromFile(filename);

			for (int i = 0; i < image.Width; i++)
			{
				for (int j = 0; j < image.Height; j++)
				{
					oldColor = image.GetPixel(i, j);
					int grey = (int) (0.3 * oldColor.R + 0.59 * oldColor.G + 0.11 * oldColor.B);
					image.SetPixel(i, j, Color.FromArgb(grey, grey, grey));
				}
			}
			string[] split = filename.Split('.', '/');
			string newFilename = split[split.Length - 2] + "_grayscale." + split[split.Length - 1];
			image.Save(newFilename);
		}
	}
	/// <summary> Converts image to black and white </summary>
	public static void BlackWhite(string[] filenames, double threshold)
	{
		Color oldColor, newColor;

		foreach (string filename in filenames)
		{
			Bitmap image = (Bitmap) Image.FromFile(filename);

			for (int i = 0; i < image.Width; i++)
			{
				for (int j = 0; j < image.Height; j++)
				{
					oldColor = image.GetPixel(i, j);
					if (oldColor.GetBrightness() >= threshold)
						newColor = Color.FromArgb(255, 255, 255);
					else if (oldColor.GetBrightness() < threshold)
						newColor = Color.FromArgb(0, 0, 0);
					image.SetPixel(i, j, newColor);
				}
			}
			string[] split = filename.Split('.', '/');
			string newFilename = split[split.Length - 2] + "_bw." + split[split.Length - 1];
			image.Save(newFilename);
		}

	}
	/// <summary> Make thumbnail version of image </summary>
	public static void Thumbnail(string[] filenames, int height)
	{
		foreach (string filename in filenames)
		{
			Image image = Image.FromFile(filename);
			int ratio = image.Height / height;
			Image resize = image.GetThumbnailImage(image.Width / ratio, height, ()=>false, IntPtr.Zero);
			
			string[] split = filename.Split('.', '/');
			string newFilename = split[split.Length - 2] + "_th." + split[split.Length - 1];
			resize.Save(newFilename);
		}
	}
}
