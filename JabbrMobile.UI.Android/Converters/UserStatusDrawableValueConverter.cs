using System;
using Cirrious.CrossCore.Converters;
using Android.Graphics.Drawables;
using JabbR.Client.Models;
using Android.Content.Res;
using Android.Graphics;

namespace JabbrMobile.Android
{
	public class UserStatusDrawableIdValueConverter : MvxValueConverter<UserStatus, int>
	{
		protected override int Convert (UserStatus value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if (value == UserStatus.Active)
				return Resource.Drawable.icon_green_circle_small;
			else
				return Resource.Drawable.icon_yellow_circle_small;
		}

		protected override UserStatus ConvertBack (int value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return UserStatus.Active;
		}
	}
}

