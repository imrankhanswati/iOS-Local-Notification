using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSceneButtonController : MonoBehaviour
{
    public void SendNotificationNow()
    {
        LocalNotification.Instance.ScheduleNotification(2f);
        Debug.Log("will send notification now.");
    }

    public void SendNotificationAfter30Sec()
    {
        LocalNotification.Instance.ScheduleNotification(30f);
        Debug.Log("will send notification after 30 sec.");
    }

    public void SendNotificationAfter1min()
    {
        LocalNotification.Instance.ScheduleNotification(60f);
        Debug.Log("will send notification after 1 min.");
    }

    public void CancelAllNotification()
    {
        LocalNotification.Instance.CancelScheduleNotification();
        Debug.Log("will cancel all notifications.");
    }
}
