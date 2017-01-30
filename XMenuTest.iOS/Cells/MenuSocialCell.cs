using System;
using CoreGraphics;
using Foundation;
using UIKit;
using XMenuTest.Core;

namespace XMenuTest.iOS
{
	public class MenuSocialCell : UITableViewCell
	{
		UIButton shareButton, twitterButton, instagramButton, facebookButton;
		public MenuSocialCell(NSString cellIdentifier, float tableViewWidth,
							  FieldControlModel field, MenuViewModel viewModel) : base(UITableViewCellStyle.Default, cellIdentifier)
		{
			ContentView.BackgroundColor = Colors.Color2;
			this.SelectionStyle = UITableViewCellSelectionStyle.None;
			shareButton = new UIButton();
			shareButton.SetImage(UIImage.FromBundle("ic_screen_share_white"), UIControlState.Normal);
			twitterButton = new UIButton();
			twitterButton.SetImage(UIImage.FromBundle("ic_lightbulb_outline_white"), UIControlState.Normal);
			instagramButton = new UIButton();
			instagramButton.SetImage(UIImage.FromBundle("ic_bug_report_white"), UIControlState.Normal);
			facebookButton = new UIButton();
			facebookButton.SetImage(UIImage.FromBundle("ic_query_builder_white"), UIControlState.Normal);

			shareButton.SetButtonStyle(UIColor.Clear, Colors.White); 
			twitterButton.SetButtonStyle(UIColor.Clear, Colors.White);
			instagramButton.SetButtonStyle(UIColor.Clear, Colors.White);
			facebookButton.SetButtonStyle(UIColor.Clear, Colors.White);

			CGRect frame = this.Frame;
			frame.Height = Sizes.FieldCellHeight;
			frame.Width = tableViewWidth;
			this.Frame = frame;

			nfloat centerX = Frame.Width / 2;
			nfloat centerY = Frame.Height / 2;
			nfloat imageDim = 25;

			shareButton.Frame = new CGRect(10,
										 centerY - shareButton.Frame.Height - (imageDim / (float)2),
										 imageDim, imageDim);
			twitterButton.Frame = new CGRect(centerX/2,
										 centerY - twitterButton.Frame.Height - (imageDim / (float)2),
										 imageDim, imageDim);
			instagramButton.Frame = new CGRect(centerX,
	                                   centerY - instagramButton.Frame.Height - (imageDim / (float)2),
										 imageDim, imageDim);
			facebookButton.Frame = new CGRect(centerX + centerX / 2,
										 centerY - facebookButton.Frame.Height - (imageDim / (float)2),
										 imageDim, imageDim);

			//shareButton.TouchUpInside += (sender, e) => viewModel.ShowSocialCommand.Execute(viewModel.Facebook);
			//twitterButton.TouchUpInside += (sender, e) => viewModel.ShowSocialCommand.Execute(viewModel.Twitter);
			//instagramButton.TouchUpInside += (sender, e) => viewModel.ShowSocialCommand.Execute(viewModel.Instagram);
			//facebookButton.TouchUpInside += (sender, e) => viewModel.ShowSocialCommand.Execute(viewModel.Facebook);

			Add(shareButton);
			Add(twitterButton);
			Add(instagramButton);
			Add(facebookButton);
		}
	}
}
