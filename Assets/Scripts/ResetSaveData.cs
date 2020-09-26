using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetSaveData : MonoBehaviour
{
    public void ResetData()
    {
        SaveSystem.SavePlayer(0);
        SceneManager.LoadScene(0);
    }
}
