using System;
using System.Drawing;
using CoreGraphics;
using UIKit;

namespace XMenuTest.iOS
{
	public static class ImageHelper
	{
		// return a new image with other color
		public static UIImage GetColoredImage(UIImage sourceImage, UIColor color)
		{
			UIImage image = sourceImage;
			UIImage coloredImage = null;

			UIGraphics.BeginImageContextWithOptions(image.Size, false, 20.0f);
			using (CGContext context = UIGraphics.GetCurrentContext())
			{

				context.TranslateCTM(0, image.Size.Height);
				context.ScaleCTM(1.0f, -1.0f);

				var rect = new RectangleF(0, 0, (float)image.Size.Width, (float)image.Size.Height);

				// draw image, (to get transparancy mask)
				context.SetBlendMode(CGBlendMode.Normal);
				context.DrawImage(rect, image.CGImage);

				// draw the color using the sourcein blend mode so its only draw on the non-transparent pixels
				context.SetBlendMode(CGBlendMode.SourceIn);
				context.SetFillColor(color.CGColor);
				context.FillRect(rect);

				coloredImage = UIGraphics.GetImageFromCurrentImageContext();
				UIGraphics.EndImageContext();
			}
			return coloredImage;
		}

		// resize the image (without trying to maintain aspect ratio)
		public static UIImage ResizeImage(UIImage sourceImage, float width, float height)
		{
			UIGraphics.BeginImageContextWithOptions(new SizeF(width, height), false, 20.0f);
			sourceImage.Draw(new RectangleF(0, 0, width, height));
			var resultImage = UIGraphics.GetImageFromCurrentImageContext();
			UIGraphics.EndImageContext();
			return resultImage;
		}
	}
}
