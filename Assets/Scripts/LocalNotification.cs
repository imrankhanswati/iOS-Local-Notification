using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalNotification : MonoBehaviour
{
    public static LocalNotification Instance;

    public void Awake()
    {
        Instance = this;
    }
    public void RegisterForNotif()//You cannot send notification to a user if he has opted out of it or it hasn’t been approved by him.Use this function to Register.
    {

        UnityEngine.iOS.NotificationServices.RegisterForNotifications(UnityEngine.iOS.NotificationType.Alert | UnityEngine.iOS.NotificationType.Badge | UnityEngine.iOS.NotificationType.Sound);
    }

    public void ScheduleNotification(float timeForNotification)
    {
        UnityEngine.iOS.LocalNotification notif = new UnityEngine.iOS.LocalNotification();
        notif.fireDate = DateTime.Now.AddSeconds(timeForNotification);
        notif.alertBody = "You’ve generated more coins! Come back and play!";
        UnityEngine.iOS.NotificationServices.ScheduleLocalNotification(notif);
    }

    public void CancelScheduleNotification()
    {
        UnityEngine.iOS.NotificationServices.CancelAllLocalNotifications();
    }
}
