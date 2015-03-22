﻿using System;
using System.CodeDom;
using System.Collections.ObjectModel;
using System.Windows.Data;
using VgzMedicijnenApp.Domain;
using VgzMedicijnenApp.Utility;

namespace VgzMedicijnenApp.Controllers
{
    public class MainController : NotifyBase
    {
        private ObservableCollection<Notification> _notifications;
        public ObservableCollection<Notification> Notifications
        {
            get { return _notifications; }
            set
            {
                _notifications = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Drug> _drugs;
        public ObservableCollection<Drug> Drugs
        {
            get { return _drugs; }
            set
            {
                _drugs = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Notification> NotificationsToday
        {
            get
            {
                ObservableCollection<Notification> notifications = new ObservableCollection<Notification>();
                foreach (Notification n in Notifications)
                {
                    if (n.Time.Day == DateTime.Now.Day)
                    {
                        notifications.Add(n);
                    }
                }
                return notifications;
            }
        }

        public MainController()
        {
            Notifications = new ObservableCollection<Notification>();
            Drugs = new ObservableCollection<Drug>();
        }
    }
}