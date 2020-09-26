using UnityEngine;

public class TogglePause : MonoBehaviour
{

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        TimerController.instance.RunTimer();
        ResumeTime();
    }

    public void ResumeTime()
    {
        Time.timeScale = 1;
    }
}
