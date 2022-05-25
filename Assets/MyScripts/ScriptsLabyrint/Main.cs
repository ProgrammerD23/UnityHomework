using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class Main : MonoBehaviour
    {
        public InputControler inputControler;
        public GameObject player;

        void Awake()
        {
            inputControler = new InputControler(player.GetComponent<Unit>());
        }

        void Update()
        {
            inputControler.Update();
        }
    }
}