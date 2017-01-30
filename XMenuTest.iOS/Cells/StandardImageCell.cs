using System;
using Foundation;
using MvvmCross.Binding.Bindings;
using MvvmCross.Binding.Bindings.SourceSteps;
using MvvmCross.Binding.iOS.Views;
using UIKit;

namespace XMenuTest.iOS
{
	public class StandardImageCell : UITableViewCell
	{
		//public static readonly MvxBindingDescription[] BindingDescriptions = new[]
		//{
		//	new MvxBindingDescription()
		//	{
		//		TargetName = "TitleText",
		//		Source = new MvxPathSourceStepDescription()
		//		{
		//			SourcePropertyPath = "Filial"
		//		}
		//	},
		//	new MvxBindingDescription()
		//	{
		//		TargetName = "DetailText",
		//		Source = new MvxPathSourceStepDescription()
		//		{
		//			SourcePropertyPath = "Descricao"
		//		}
		//	}
		//};

		public StandardImageCell(UITableViewCellStyle cellStyle, NSString cellIdentifier, 
		                         FieldControlModel field) : base(cellStyle, cellIdentifier)
		{
			this.BackgroundColor = Colors.Color2;
			TextLabel.SetLabelStyle(Colors.White, Font.Regular(Sizes.FontSizeNormal));

			TextLabel.Text = field.LabelText ?? StringsResources.NullValueError;
			if (field.ImageBundle != null)
			{
				ImageView.Image = ImageHelper.ResizeImage(UIImage.FromFile(field.ImageBundle ?? ""),
				                                         24,24);
			}
			if (cellStyle == UITableViewCellStyle.Subtitle)
			{
				DetailTextLabel.SetLabelStyle(Colors.White, Font.Regular(Sizes.FontSizeSmall));
				DetailTextLabel.Text = field.SubLabelText;
			}
		}
	}
}
