using System.IO;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
public class Waypoints : MonoBehaviour
{
    public List<Transform> nodes = new List<Transform>();

    public string directoryName;
    public string savingPath;
    public string SceneName;

    public string SavingPath { get => savingPath; set => savingPath = value; }

    private void OnDrawGizmos()
    {
        SceneName = UnityEditor.SceneManagement.EditorSceneManager.GetActiveScene().name;
        directoryName = "BonusData";
        savingPath = Path.Combine((Application.dataPath + "/" + directoryName), "BonusMap" + SceneName + ".xml");
    }
}
#endif
