using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace XMenuTest.iOS
{
	public class MenuButtonCell : UITableViewCell
	{
		UILabel titleText, subtitleText;
		UIButton button;
		public MenuButtonCell( NSString cellIdentifier, float tableViewWidth,
		                      FieldControlModel field)
			: base(UITableViewCellStyle.Default, cellIdentifier)
		{
			titleText = new UILabel();
			subtitleText = new UILabel();
			button = new UIButton();
			CGRect frame = this.Frame;
			//nfloat centerX = Frame.Width / 2;
			//nfloat centerY = Frame.Height / 2;
			nfloat buttonHeight = 50;
			nfloat buttonWidth = Frame.Width/3;

			this.BackgroundColor = Colors.Color2;
			this.SelectionStyle = UITableViewCellSelectionStyle.None;

			frame.Height = Sizes.CenterInputCellHeight;
			frame.Width = tableViewWidth;
			this.Frame = frame;

			button.SetButtonStyle(Colors.Color1, Colors.White);

			titleText.Frame = new CGRect(12, 10,
			                             Frame.Width, 30);
			titleText.SetLabelStyle(Colors.Color1, Font.Regular(Sizes.FontSizeNormal));

			subtitleText.Frame = new CGRect(12, 20,
			                                Frame.Width-10, 70);
			subtitleText.SetLabelStyle(Colors.White, Font.Regular(Sizes.FontSizeSmall));
			subtitleText.LineBreakMode = UILineBreakMode.TailTruncation;
			subtitleText.Lines = 4;

			button.Frame = new CGRect(12, Frame.Height - buttonHeight - 10,
			                          buttonWidth, buttonHeight);
			button.SetViewConnerRadius(UIRectCorner.AllCorners, Sizes.ConnerSizes);

			Add(titleText);
			Add(subtitleText);
			Add(button);

			titleText.Text = field.LabelText ?? StringsResources.NullValueError;
			subtitleText.Text = field.SubLabelText ?? StringsResources.NullValueError;
			button.SetTitle(field.EditLabelPlaceHolder, UIControlState.Normal);
		}
	}
}
