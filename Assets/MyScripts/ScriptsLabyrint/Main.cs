using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class Main : MonoBehaviour
    {
        public InputControler inputControler;
        public GameObject player;
        public BadBonus badBonus;
        public GoodBonus goodBonus;

        void Awake()
        {
            inputControler = new InputControler(player.GetComponent<Unit>());
            badBonus.OnCaughtPlayer += GameOver;
            goodBonus.AddPoints += GameViner;
        }

        private void GameOver(string name)
        {
            Debug.Log(name);
        }

        private void GameViner(int point)
        {
            Debug.Log(point);
        }

        void Update()
        {
            inputControler.Update();
        }
    }
}