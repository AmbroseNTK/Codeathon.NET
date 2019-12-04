using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeathon.API.Utilities
{
    public enum NotificationStatus
    {
        Info,
        Warning,
        Error
    }
    public class Notification
    {
        private NotificationStatus status;
        private string info;

        public NotificationStatus Status { get => status; set => status = value; }
        public string Info { get => info; set => info = value; }
    }
    public delegate void PushNotification(Notification notification);
    public class Notificator
    {
        public Notificator()
        {
            notifications = new Queue<Notification>();
        }
        /// <summary>
        /// When new notification was pushed
        /// </summary>
        public event PushNotification OnPushNotification;

        private Queue<Notification> notifications;
        /// <summary>
        /// Push new notification to the system
        /// </summary>
        /// <param name="notification">New notification</param>
        public void Push(Notification notification)
        {
            notifications.Enqueue(notification);
            OnPushNotification?.Invoke(notification);
        }

        /// <summary>
        /// Remove earliest notification
        /// </summary>
        public void Discard()
        {
            if (notifications.Count != 0)
            {
                notifications.Dequeue();
            }
        }
    }
}
