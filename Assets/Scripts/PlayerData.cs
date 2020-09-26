using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int highestLevelCleared;

    public PlayerData(int levelCleared)
    {
        highestLevelCleared = levelCleared;
    }
}
