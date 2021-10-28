using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class DataPersistence : MonoBehaviour
{
    // Start is called before the first frame update

    public static DataPersistence Instance;

    public TMP_InputField Username;
    public int currentHighScore;
    public string userName;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadHighScore();
    }

    [System.Serializable]
    class SaveData
    {
        public int newHighScore;
        public string newUserName;
    }

    public void SaveHighScore()
    {
        SaveData data = new SaveData();
        data.newHighScore = currentHighScore;
        data.newUserName = userName;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile2.json", json);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile2.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            currentHighScore = data.newHighScore;
            userName = data.newUserName;
        }
    }


}
