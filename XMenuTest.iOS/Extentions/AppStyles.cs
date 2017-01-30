using System;
using CoreAnimation;
using CoreGraphics;
using UIKit;

namespace XMenuTest.iOS
{
	public static class AppStyles
	{
		public static void SetTableStyle(this UITableView table, UIColor color, bool allowSelection = false)
		{
			table.BackgroundColor = color;
			table.AllowsSelection = allowSelection;
			table.SeparatorStyle = UITableViewCellSeparatorStyle.None;
		}

		public static void SetButtonStyle(this UIButton button, UIColor backgroundColor, UIColor tintColor,
										  UIColor textColor = null, UIFont font = null)
		{
			button.BackgroundColor = backgroundColor;
			button.TintColor = tintColor;
			if (textColor != null)
				button.SetTitleColor(textColor, UIControlState.Normal);
			if (font != null)
				button.Font = font;
		}

		public static void SetLabelStyle(this UILabel label, UIColor textColor, UIFont font)
		{
			label.TextColor = textColor;
			label.Font = font;
		}

		public static void SetViewConnerRadius(this UIView view, UIRectCorner conners, CGSize sizes)
		{
			var maskPath = UIBezierPath.FromRoundedRect(view.Bounds, conners, sizes);

			var maskLayer = new CAShapeLayer();
			maskLayer.Path = maskPath.CGPath;
			maskLayer.Frame = view.Bounds;

			view.Layer.Mask = maskLayer;
		}
	}
}
