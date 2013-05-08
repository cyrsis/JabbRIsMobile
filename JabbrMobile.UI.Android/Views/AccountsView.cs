using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Cirrious.MvvmCross.Droid.Views;

namespace JabbrMobile.Android.Views
{
	[Activity (Label = "Accounts")]			
	public class AccountsView : BaseView
	{
		protected override void OnViewModelSet ()
		{
			SetContentView (Resource.Layout.View_Accounts);

			MenuId = Resource.Menu.AccountsMenu;
		}
	}
}

