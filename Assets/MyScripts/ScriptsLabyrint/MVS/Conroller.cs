using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze {
    public class Conroller
    {
        private Transform playerT;
        private View triggerT;
        private View playerView;

        public Conroller(View player, View trigger)
        {
            playerView = player;
            playerT = player.transform;
            triggerT = trigger;

            triggerT.OnLevelObjectContact += ControllerRecievAction;
        }

        private void ControllerRecievAction(Collider contactView, int Val, Transform valT)
        {
            Debug.Log("Обработчик");
        }
    }
}
