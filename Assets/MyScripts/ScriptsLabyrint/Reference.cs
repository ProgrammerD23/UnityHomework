using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Maze
{
    public class Reference
    {
        private GameObject goodBonusetxt;
        private GameObject badBonusetxt;
        private Button restartBtn;
        private Canvas canvas;

        public Canvas Canvas
        {
            get
            {
                if (canvas == null)
                {
                    var gameObject = Object.FindObjectsOfType<Canvas>();
                }
                return canvas;
            }
        }

        public GameObject GoodBonuse
        {
            get
            {
                if (goodBonusetxt == null)
                {
                    var gameObject = Resources.Load<GameObject>("UI/GoodBonusText");
                    goodBonusetxt = Object.Instantiate(gameObject, Canvas.transform);
                }
                return goodBonusetxt;
            }
        }

        public GameObject BadBonuse
        {
            get
            {
                if (badBonusetxt == null)
                {
                    var gameObject = Resources.Load<GameObject>("Assets/Resources/UI/BadBonusText");
                    badBonusetxt = Object.Instantiate(gameObject, Canvas.transform);
                }
                return badBonusetxt;
            }
        }

        public Button RestartBtn
        {
            get
            {
                if (restartBtn == null)
                {
                    var gameObject = Resources.Load<Button>("UI/RestartBtn");
                    restartBtn = Object.Instantiate(gameObject, Canvas.transform);
                }
                return restartBtn;
            }
        }

    }
}
