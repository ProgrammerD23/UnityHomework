using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class Model : MonoBehaviour
    {
        public View playerView;
        public View triggerView;
        private Conroller conroller;

        private void Awake()
        {
            conroller = new Conroller(playerView, triggerView);
        }
    }
}
