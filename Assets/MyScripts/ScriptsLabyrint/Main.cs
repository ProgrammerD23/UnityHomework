using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Maze
{
    public class Main : MonoBehaviour
    {
        private ListExecuteObjects interactiveObject;

        private DisplayGoodBonuse displayBonuse;
        private DisplayEndGame displayEndGame;
        //private Reference reference;

        public InputControler inputControler;
        public GameObject player;

        private int countBonuse = 1;

        public GameObject bonusetxt;
        public GameObject endGametxt;
        public Button restartbtn;

        void Awake()
        {
            //reference = new Reference();

            interactiveObject = new ListExecuteObjects();

            inputControler = new InputControler(player.GetComponent<Unit>());

            //displayBonuse = new DisplayGoodBonuse(reference.GoodBonuse);
            //displayEndGame = new DisplayEndGame(reference.BadBonuse);

            displayBonuse = new DisplayGoodBonuse(bonusetxt);
            displayEndGame = new DisplayEndGame(endGametxt);
            foreach (var o in interactiveObject)
            {
                if(o is BadBonus badBonuse)
                {
                    badBonuse.OnCaughtPlayer += CaughtPlayer;
                    badBonuse.OnCaughtPlayer += displayEndGame.GameOver;
                }
                if(o is GoodBonus goodBonus)
                {
                    goodBonus.AddPoints += AddPoint;
                    goodBonus.AddPoints += displayBonuse.Display;
                }

            }

            //reference.RestartBtn.onClick.AddListener(RestartGame);
            //reference.RestartBtn.gameObject.SetActive(false);

            restartbtn.onClick.AddListener(RestartGame);
            restartbtn.gameObject.SetActive(false);

        }

        private void CaughtPlayer(string value)
        {
            //reference.RestartBtn.gameObject.SetActive(true);
            restartbtn.gameObject.SetActive(true);
            Time.timeScale = 0.0f;
        }

        private void AddPoint(int point)
        {
            countBonuse += point;
            //displayBonuse.Display(countBonuse);
        }

        private void RestartGame()
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1.0f;
        }

        void Update()
        {
            inputControler.Update();
        }

        public void Dispose()
        {
            foreach (var o in interactiveObject)
            {
                if (o is BadBonus badBonus)
                {
                    badBonus.OnCaughtPlayer -= CaughtPlayer;
                    badBonus.OnCaughtPlayer -= displayEndGame.GameOver;
                }
                if (o is GoodBonus goodBonus)
                {
                    goodBonus.AddPoints -= AddPoint;
                    goodBonus.AddPoints -= displayBonuse.Display;
                }
            }
        }

    }
}