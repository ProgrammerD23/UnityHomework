using System.IO;
using UnityEngine;

public class JSonData : ISave
{
    string path = Path.Combine(Application.dataPath, "JSonData.json");
    public void Save(SaveData bonus)
    {
        string FileJSon = JsonUtility.ToJson(bonus);
        File.WriteAllText(path, FileJSon);
    }

    public SaveData Load()
    {
        SaveData result = new SaveData();

        if (!File.Exists(path))
        {
            Debug.Log("ERROR NOT FILE");
            return result;
        }

        string tempJSon = File.ReadAllText(path);
        result = JsonUtility.FromJson<SaveData>(tempJSon);

        return result;
    }

}
