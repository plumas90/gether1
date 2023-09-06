using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour
{
    public Text TimeTxT;

    void Update()
    {
        GetCurrentDate();
    }
    public void GetCurrentDate()
    {
        string DayTime = DateTime.Now.ToString("HH:mm");
        TimeTxT.text = DayTime;
    }

}