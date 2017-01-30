using System;
using System.Linq;
using Foundation;
using MvvmCross.Binding.iOS.Views;
using UIKit;
using XMenuTest.Core;

namespace XMenuTest.iOS
{
	public class MenuTableSource : MvxStandardTableViewSource
	{
		//private FieldControlModel _fieldBind;
		private MenuViewModel _viewModel;
		private static readonly NSString _cellIdentifier = new NSString("MenuCell");
		private static NSIndexPath _selectedIndex = new NSIndexPath();

		public MenuTableSource(UITableView table, MenuViewModel viewModel) : base(table)
		{
			_viewModel = viewModel;
		}

		protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
		{
			UITableViewCell cell;

			cell = new UITableViewCell();
			switch (ItemsSource.Cast<FieldControlModel>().ElementAt(indexPath.Row).Type)
			{
				case FieldType.Header:
					cell = new MenuHeaderCell(_cellIdentifier, (float)TableView.Frame.Width,
											  ItemsSource.Cast<FieldControlModel>().ElementAt(indexPath.Row));
					break;
				case FieldType.Disclosure:
					cell = new StandardImageCell(UITableViewCellStyle.Subtitle, _cellIdentifier,
												 ItemsSource.Cast<FieldControlModel>().ElementAt(indexPath.Row));
					cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
					cell.TextLabel.TextColor = Colors.Color1;
					break;
				case FieldType.MenuButton:
					cell = new MenuButtonCell(_cellIdentifier, (float)TableView.Frame.Width,
											  ItemsSource.Cast<FieldControlModel>().ElementAt(indexPath.Row));
					break;
				case FieldType.MenuItemImage:
					cell = new StandardImageCell(UITableViewCellStyle.Default, _cellIdentifier,
												 ItemsSource.Cast<FieldControlModel>().ElementAt(indexPath.Row));
					break;
				case FieldType.MenuItemSocial:
					cell = new MenuSocialCell(_cellIdentifier, (float)TableView.Frame.Width,
											  ItemsSource.Cast<FieldControlModel>().ElementAt(indexPath.Row),
											  _viewModel);
					break;
				case FieldType.Text:
					cell = new OnlySingleLineTextCell(UITableViewCellStyle.Default, _cellIdentifier,
													  (float)TableView.Frame.Width,
													  ItemsSource.Cast<FieldControlModel>().ElementAt(indexPath.Row));
					break;
			}

			try
			{
				if (_selectedIndex.Row == indexPath.Row &&
				_selectedIndex.Section == indexPath.Section)
					SetCellColor(cell, Colors.Color4);
			}
			catch (Exception ex)
			{

			}

			return cell;
		}

		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			tableView.DeselectRow(indexPath, true);

			for (int i = 0; i < tableView.NumberOfRowsInSection(0); i++)
			{
				UITableViewCell cell = tableView.CellAt(NSIndexPath.FromItemSection(i, 0));
				var field = StringsResources.MenuFields().Find((obj) => obj.Row == i);
				if (field.Type == FieldType.MenuItemSocial ||
					field.Type == FieldType.Header)
					continue;

				if (cell != null)
				if (cell?.TextLabel?.TextColor != Colors.White)
					SetCellColor(cell, Colors.White);
			}

			var cellAtIndex = tableView.CellAt(indexPath);
			SetCellColor(cellAtIndex, Colors.Color4);

			var item = StringsResources.MenuFields().Find((obj) => obj.Row == indexPath.Row);
			var type = (MenuType)Enum.ToObject(typeof(MenuType), item.ActionType);
			switch (type)
			{
				case MenuType.Home:
					_viewModel.ShowHomeCommand.Execute();
					break;
				case MenuType.HelpAndFeedback:
					_viewModel.ShowHelpCommand.Execute();
					break;
				case MenuType.Button:
					break;
				case MenuType.Settings:
					_viewModel.ShowSettingCommand.Execute();
					break;
				case MenuType.Logout:
					_viewModel.ShowLoginCommand.Execute();
					break;
			}

			_selectedIndex = indexPath;
		}

		private void SetCellColor(UITableViewCell cell, UIColor color)
		{
			if (cell != null)
			{
				if (cell.TextLabel != null)
					cell.TextLabel.TextColor = color;
				if (cell.ImageView.Image != null)
					cell.ImageView.Image = ImageHelper.GetColoredImage(cell.ImageView.Image,
																	   color);
			}
		}

		public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
		{
			if (ItemsSource.Cast<FieldControlModel>().ElementAt(indexPath.Row).Type == FieldType.Header)
				return Sizes.MenuHeaderHeight;
			else if (ItemsSource.Cast<FieldControlModel>().ElementAt(indexPath.Row).Type == FieldType.MenuButton)
				return Sizes.CenterInputCellHeight;
			else
				return Sizes.FieldCellHeight;
		}

		protected override object GetItemAt(NSIndexPath indexPath)
		{
			return _viewModel;
		}
	}
}
