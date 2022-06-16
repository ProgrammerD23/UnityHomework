using System.IO;
using UnityEditor;
using System.Xml.Serialization;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    [CustomEditor(typeof(Waypoints))]
    public class SaveWaypoints : Editor
    {
        private static XmlSerializer serializer;
        public List<SVect3> savingNodes = new List<SVect3>();

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            Waypoints Base = (Waypoints)target;

            if(serializer == null)
            {
                serializer = new XmlSerializer(typeof(SVect3[]));
            }

            if (GUILayout.Button("Сохранить"))
            {
                if(Base.nodes.Count > 0)
                {
                    foreach(Transform item in Base.nodes)
                    {
                        if (!savingNodes.Contains(item.position))
                        {
                            savingNodes.Add(item.position);
                        }
                    }
                }

                using (FileStream file = new FileStream(Base.SavingPath, FileMode.Create))
                {
                    serializer.Serialize(file, savingNodes.ToArray());
                }

            }

        }
    }

}
