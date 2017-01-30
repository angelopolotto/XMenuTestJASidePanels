using System;
using System.Drawing;
using CoreGraphics;
using Foundation;
using UIKit;

namespace XMenuTest.iOS
{
	public class MenuHeaderCell : UITableViewCell
	{
		UIImageView headingLabel;
		UIImageView imageView;
		public MenuHeaderCell(NSString cellIdentifier, float tableViewWidth,
		                      FieldControlModel field) : base(UITableViewCellStyle.Default, cellIdentifier)
		{
			ContentView.BackgroundColor = Colors.Color1;
			headingLabel = new UIImageView();
			imageView = new UIImageView();

			headingLabel.Image = UIImage.FromBundle("header_logo");
			imageView.Image = ImageHelper.ResizeImage(UIImage.FromFile(field.ImageBundle ?? ""),
			                                         35, 25);

			CGRect frame = this.Frame;
			frame.Height = Sizes.MenuHeaderHeight;
			frame.Width = tableViewWidth;
			this.Frame = frame;


			nfloat centerX = Frame.Width / 2;
			nfloat centerY = Frame.Height / 2;

			nfloat imageDim = 25;
			imageView.Frame = new CGRect((float)this.Frame.Width -50, 
			                             centerY - imageView.Frame.Height - (imageDim/(float)2), 
			                             imageDim, imageDim);
			headingLabel.Frame = new CGRect(0, centerY - headingLabel.Frame.Height - 12.5, 
			                                (float)this.Frame.Width - 70, 30);
			Add(imageView);
			Add(headingLabel);
		}
	}


}
