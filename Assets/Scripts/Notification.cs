using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notification : MonoBehaviour
{
    [SerializeField] GameObject notification;

    private void Start()
    {
        Time.timeScale = 0f;
    }
    public void CloseNotification()
    {
        Time.timeScale = 1f;
        notification.SetActive(false);
    }
}
