using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public int levelToLoad = 0;
    public Button button;
    public Color accessibleLevelColour;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            var cb = button.colors;

            int highestLevelCleared = SaveSystem.LoadPlayer().highestLevelCleared;

            if (levelToLoad != 0 && levelToLoad <= highestLevelCleared + 1)
            {
                cb.normalColor = accessibleLevelColour;
                cb.highlightedColor = accessibleLevelColour;
                cb.pressedColor = accessibleLevelColour;
                button.colors = cb;
            }
            else
            {
                button.interactable = false;
            }
        }
    }

    public void StartGame()
    {
        if (SceneManager.sceneCountInBuildSettings < levelToLoad + 1)
        {
            return;
        }
        SceneManager.LoadScene(levelToLoad);
    }
}
