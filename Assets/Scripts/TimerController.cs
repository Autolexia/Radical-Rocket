using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public static TimerController instance;

    public Text TimeCounter;
    public Text TimeCounter2;
    public Text TimeCounter3;


    private TimeSpan timePlaying;
    private bool timerGoing;

    private float elapsedTime;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        TimeCounter.text = "00:00:00";
        timerGoing = false;
    }

    public void BeginTimer()
    {
        timerGoing = true;
        elapsedTime = 0f;

        RunTimer();
    }

    public void EndTimer()
    {
        timerGoing = false;
    }

    public void RunTimer()
    {
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = timePlaying.ToString("mm':'ss':'ff");
            TimeCounter.text = timePlayingStr;
            TimeCounter2.text = TimeCounter.text;
            TimeCounter3.text = "Time: " + TimeCounter.text;

            yield return null;
        }
    }
}
