using System.Net.Mime;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SafeSystem{
    
    public static void SavePlayer (PlayerStats player, CharacterController character) {
        BinaryFormatter formatter = new BinaryFormatter();

        string path  = Application.persistentDataPath + "/player.sve";
        FileStream stream =  new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player, character);

        formatter.Serialize(stream, data);
        stream.Close(); 
    }

    public static PlayerData LoadPlayer () {
        string path = Application.persistentDataPath + "/player.sve";
        if (File.Exists(path)) {

            BinaryFormatter  formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;

        }else {
            Debug.LogError("Save file not found in " + path + ". Da muss es wohl einen Fehler geben.");
            return null;
        }
    }

}
