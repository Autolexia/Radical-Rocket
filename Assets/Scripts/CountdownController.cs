using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;
    public GameObject objectToShow;

    private void Start()
    {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();

            FadeAndScaleCountdownText();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        FadeAndScaleCountdownText();

        countdownDisplay.text = "GO!";
        objectToShow.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.25f);

        TimerController.instance.BeginTimer();
        yield return new WaitForSeconds(1f);
        countdownDisplay.gameObject.SetActive(false);
    }

    private void FadeAndScaleCountdownText()
    {
        LeanTween.scale(countdownDisplay.gameObject, new Vector3(5, 5, 5), 1f);
        countdownDisplay.gameObject.transform.localScale = new Vector3(1, 1, 1);
        LeanTween.value(countdownDisplay.gameObject, 1, 0, 1).setOnUpdate((float val) =>
        {
            Color c = countdownDisplay.color;
            c.a = val;
            countdownDisplay.color = c;
        });
    }
}
