using System;
namespace XMenuTest.iOS
{
	public class FieldControlModel
	{
		public string Group { get; set; }
		public string LabelText { get; set; }
		public string SubLabelText { get; set; }
		public string EditLabel { get; set; }
		public string EditLabelPlaceHolder { get; set; }
		public string ImageBundle { get; set; }
		public FieldType Type { get; set; }
		public int MaxLength { get; set; }
		public Enum ActionType { get; set; }
		public int Row { get; set; }
	}

	public enum FieldType
	{
		Header,
		Text,
		Disclosure,
		MenuItemImage,
		MenuItemSocial,
		MenuButton,
	}

	public enum MenuType
	{
		Home,
		HelpAndFeedback,
		Button,
		Settings,
		Logout,
		Share,
	}
}
