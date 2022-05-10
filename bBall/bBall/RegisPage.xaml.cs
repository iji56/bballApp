﻿using bBall.Common;
using bBall.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bBall
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisPage : ContentPage
	{
        DbService _dbServ;
        //RestService _restService;

        public RegisPage ()
		{
			InitializeComponent ();

            _dbServ = new DbService();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

        }

        async void OnRegButtonClicked(object sender, EventArgs e)
        {
            bool bIsMail = CommonFunctions.isValidEmail(_txtEmail.Text);

            if (String.IsNullOrEmpty(_txtName.Text))
            {
                DisplayAlert("Warning", "Display name should not be empty!", "OK");
            }
            else if (String.IsNullOrEmpty(_txtEmail.Text))
            {
                DisplayAlert("Warning", "The field Email should not be empty!", "OK");
            }
            else if (!bIsMail)
            {
                DisplayAlert("Warning", "The field Email should be in email format (someone@domain.com!", "OK");
            }
            else if (String.IsNullOrEmpty(_txtPassword.Text))
            {
                DisplayAlert("Warning", "The field Password should not be empty!", "OK");
            }
            else if (String.IsNullOrEmpty(_txtPassword.Text))
            {
                DisplayAlert("Warning", "The field Password should not be empty!", "OK");
            }

            else
            {
                await Navigation.PushAsync(new I_AgreePage(_txtName.Text, _txtEmail.Text, _txtPassword.Text));
            }

        }

       

        async private void OnBackClicked(object sender, EventArgs e)
        {

            await Navigation.PopAsync();

        }

    }
}