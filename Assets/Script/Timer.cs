using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    float CurrentTime;
    float timer = 0.0f;
    int seconds;
    public int StartMinutes;
    public Text currentTextTime;

    void Start()
    {
        CurrentTime = StartMinutes * 60;
    }


    void Update()
    {
        CurrentTime = CurrentTime - Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(CurrentTime);
        currentTextTime.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
        timer += Time.deltaTime;
        seconds = (int)(timer);

        
        if(seconds == 300)
        {
            //GameManager.instance.GameOver();
        }

    }
}
