using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCountDown : MonoBehaviour {
    public Text timeText;
    public int timeCount = 30;
    public bool isRunCountDown = false; //开关

    Int64 endTime;

    void Awake(){
        if(timeText == null){
            timeText = GetComponent<Text>();
        }
        endTime = GetTimeStamp() + timeCount;
        // Test
        isRunCountDown = true;
    }
	
	void Update () {
        CountDown();
    }

    void CountDown(){
        if (isRunCountDown){
            int timeCount = (int)(endTime - GetTimeStamp());
            if (timeCount < 0) {
                timeCount = 0;
                isRunCountDown = false;
            }
            timeText.text = timeCount.ToString();
        }
    }

    Int64 GetTimeStamp()
    {
        TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
        return Convert.ToInt64(ts.TotalSeconds);
    }
}
