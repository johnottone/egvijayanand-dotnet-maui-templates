﻿namespace MauiApp1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            // Register the routes of the detail pages
            Routing.RegisterRoute("newevent", typeof(NewEventPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Current.GoToAsync("//login");
        }
    }
}