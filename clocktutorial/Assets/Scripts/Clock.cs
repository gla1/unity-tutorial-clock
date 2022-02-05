using System;
using UnityEngine;
public class Clock : MonoBehaviour
{

    [SerializeField]Transform hoursPivot;
    [SerializeField]Transform minutesPivot;
    [SerializeField]Transform secondsPivot;

    const float hoursToDegrees = -30;
    const float minutesToDegrees = -6;
    const float secondsToDegrees = -6;
    void Awake (){
        DateTime time = DateTime.Now;
        hoursPivot.localRotation = Quaternion.Euler(0,0, hoursToDegrees * time.Hour);
        minutesPivot.localRotation = Quaternion.Euler(0,0, minutesToDegrees * time.Minute);
        secondsPivot.localRotation = Quaternion.Euler(0,0, secondsToDegrees * time.Second);
    }
    
    void Update (){
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0,0, hoursToDegrees * (float) time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0,0, minutesToDegrees * (float) time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0,0, secondsToDegrees * (float) time.TotalSeconds);
    }
}