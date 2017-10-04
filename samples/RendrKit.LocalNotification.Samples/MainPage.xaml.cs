﻿using Xamarin.Forms;
using System;
using RendrKit.LocalNotifications.Models;

namespace RendrKit.LocalNotification.Samples
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.NotificationTimePicker.Time = (DateTime.UtcNow - DateTime.UtcNow.Date);
            this.AddNotificationButton.Clicked += AddNotificationButton_Clicked;
        }

        void AddNotificationButton_Clicked(object sender, System.EventArgs e)
        {
            var notification = new LocalNotifications.Models.LocalNotification()
            {
                Text = "Testing Notification",
                FireDate = DateTime.UtcNow.Date.AddHours(this.NotificationTimePicker.Time.Hours).AddMinutes(this.NotificationTimePicker.Time.Minutes)
            };

            App.NotificationService.AddNotification(notification);
        }
    }
}