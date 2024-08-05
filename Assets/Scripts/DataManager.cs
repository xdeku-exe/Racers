using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance { get; private set; }
    public int currentCar;
    public string path;

    public void Awake()
    {
        path = path = Application.persistentDataPath + "/player.dat";
        // Если где-то есть еще DataManager, то удалим его, иначе - DataManager будет текущий объект
        if (Instance != null && Instance != this) Destroy(gameObject);
        else Instance = this;
        DontDestroyOnLoad(gameObject);
        Load();
    }

    public void Save()
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        FileStream file = File.Create(path);

        PlayerData data = new();
        // DATA THAT WILL SAVE
        data.currentCar = currentCar;

        binaryFormatter.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        if (File.Exists(path))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream file = File.Open(path, FileMode.Open);
            PlayerData playerData = (PlayerData)binaryFormatter.Deserialize(file);

            // DATA THAT WILL LOAD
            currentCar = playerData.currentCar;
            file.Close();
        }
    }

}

[System.Serializable]
class PlayerData
{
    public int currentCar;
}

