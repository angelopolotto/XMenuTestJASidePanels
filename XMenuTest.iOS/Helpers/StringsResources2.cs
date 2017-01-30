using System;
using System.Collections.Generic;

namespace XMenuTest.iOS
{
	public static class StringsResources
	{
		public static readonly string NullValueError = "Null value found";

		public static List<FieldControlModel> MenuFields()
		{
			var fields = new List<FieldControlModel>();
			var resolution = "";
			var src = "";
			var row = 0;

			fields.Add(new FieldControlModel
			{
				LabelText = "MADERO",
				Type = FieldType.Header,
				ImageBundle = src + "ic_home_white" + resolution + ".png",
				ActionType = MenuType.Home,
				Row = row++
			});
			fields.Add(new FieldControlModel
			{
				LabelText = "Help",
				SubLabelText = "Help View",
				//ImageBundle = src + "ic_help_white" + resolution + ".png",
				Type = FieldType.Disclosure,
				ActionType = MenuType.HelpAndFeedback,
				Row = row++
			});
			fields.Add(new FieldControlModel
			{
				LabelText = "Settings",
				Type = FieldType.MenuItemImage,
				ImageBundle = src + "ic_settings_white" + resolution + ".png",
				ActionType = MenuType.Settings,
				Row = row++
			});
			fields.Add(new FieldControlModel
			{
				LabelText = "Logout",
				Type = FieldType.Text,
				ActionType = MenuType.Logout,
				Row = row++
			});
			fields.Add(new FieldControlModel
			{
				LabelText = "Buttom example",
				SubLabelText = "Cell with button",
				EditLabelPlaceHolder = "Button",
				Type = FieldType.MenuButton,
				ActionType = MenuType.Button,
				Row = row++
			});
			fields.Add(new FieldControlModel
			{
				Type = FieldType.MenuItemSocial,
				ActionType = MenuType.Share,
				Row = row++
			});

			return fields;
		}
	}
}
