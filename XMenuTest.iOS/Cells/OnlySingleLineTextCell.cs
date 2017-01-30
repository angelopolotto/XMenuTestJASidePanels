using CoreGraphics;
using Foundation;
using UIKit;

namespace XMenuTest.iOS
{
	public class OnlySingleLineTextCell : UITableViewCell
	{
		//public static readonly MvxBindingDescription[] BindingDescriptions = new[]
		//{
		//	new MvxBindingDescription()
		//	{
		//		TargetName = "TitleText",
		//		Source = new MvxPathSourceStepDescription()
		//		{
		//			SourcePropertyPath = "LabelText"
		//		}
		//	}
		//};

		public OnlySingleLineTextCell(UITableViewCellStyle cellStyle, NSString cellIdentifier, float tableViewWidth, 
		                              FieldControlModel field, float cellHeight = 30f)
			: base(cellStyle, cellIdentifier)
		{
			TextLabel.Text = field.LabelText;
			TextLabel.SetLabelStyle(Colors.White, Font.Regular(Sizes.FontSizeNormal));
			this.BackgroundColor = Colors.Color2;

			CGRect frame = this.Frame;

			frame.Height = cellHeight;
			frame.Width = tableViewWidth;
			this.Frame = frame;
		}
	}
}
