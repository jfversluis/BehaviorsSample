﻿using Xamarin.Forms;

namespace BehaviorsSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageModel();
        }
    }
}