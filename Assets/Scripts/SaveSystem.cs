using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveSystem
{
    public static void SavePlayer (int levelCleared)
    {
        var formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.zaq";
        var stream = new FileStream(path, FileMode.Create);

        var data = new PlayerData(levelCleared);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.zaq";
        if (!File.Exists(path))
        {
            SavePlayer(0);
        }

        var formatter = new BinaryFormatter();
        var stream = new FileStream(path, FileMode.Open);

        var data = formatter.Deserialize(stream) as PlayerData;
        stream.Close();

        return data;
    }
}
