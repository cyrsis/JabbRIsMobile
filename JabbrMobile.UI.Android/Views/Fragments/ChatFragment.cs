using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Cirrious.MvvmCross.Droid.Fragging.Fragments;
using Cirrious.MvvmCross.Binding.Droid.BindingContext;
using Cirrious.MvvmCross.Binding.Droid.Views;

namespace JabbrMobile.Android.Views
{
	public class ChatFragment : MvxFragment
	{
		EditText chatText;

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			base.OnCreateView (inflater, container, savedInstanceState);

			var view = this.BindingInflate (Resource.Layout.Fragment_Chat, null);

			chatText = view.FindViewById<EditText> (Resource.Id.chatText);

			return view;
		}

		public void AppendText (string text)
		{
			if (chatText != null)
			{
				if (!string.IsNullOrEmpty (chatText.Text))
					text = " " + text;

				chatText.Text = (chatText.Text ?? "") + text + " ";

				chatText.SetSelection (chatText.Text.Length);
			}
		}
	}
}

