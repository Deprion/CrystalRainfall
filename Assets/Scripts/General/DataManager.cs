using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager inst;
    public PlayerData Data;
    private string path;

    private void Awake()
    {
        inst = this;
        path = Application.persistentDataPath + "/data.crs";
        DontDestroyOnLoad(this);
        LoadData();
    }

    public class PlayerData
    {
        public int StrengthCrystal = 0;
        public int AgilityCrystal = 0;
        public int EnduranceCrystal = 0;
    }
    private void LoadData()
    {
        if (File.Exists(path))
        {
            Data = JsonUtility.FromJson<PlayerData>(File.ReadAllText(path));
        }
        else
        {
            Data = new PlayerData();
        }
    }
    private void SaveData()
    {
        File.WriteAllText(path, JsonUtility.ToJson(Data));
    }
    private void OnApplicationFocus(bool focus)
    {
        if (!focus)
        {
            SaveData();
        }
    }
}
