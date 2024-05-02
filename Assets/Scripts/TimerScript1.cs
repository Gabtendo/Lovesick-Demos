using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript1 : MonoBehaviour
{
    public string LevelToLoad;
    private float timer = 7f;
    private Text timerSeconds;

    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

   
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f0");
        if (timer <= 0)
        {
            Application.LoadLevel(LevelToLoad);
        }
    }
}
