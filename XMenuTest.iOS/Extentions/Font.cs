using System;
using System.Diagnostics;
using UIKit;

namespace XMenuTest.iOS
{
	public static class Font
	{
		public static UIFont Light(nfloat size)
		{
			return UIFont.FromName("GillSans-Light", size);
		}

		public static UIFont Regular(nfloat size)
		{
			return UIFont.FromName("GillSans", size);
		}

		public static UIFont SemiBold(nfloat size)
		{
			return UIFont.FromName("GillSans-SemiBold", size);
		}

		public static void PrintAllFontsName()
		{
			foreach (string sName in UIFont.FamilyNames)
			{
				foreach (string sFontName in UIFont.FontNamesForFamilyName(sName))
				{
					Debug.WriteLine(string.Format("FamilyName: {0} FontName: {1}", sName, sFontName));
				}
			}
		}
	}
}
