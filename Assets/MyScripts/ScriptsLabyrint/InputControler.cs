using UnityEngine;

namespace Maze
{
    public class InputControler
    {
        private readonly Unit UnitPlayer;
        public float horizontal;
        public float vertical;

        public InputControler(Unit player)
        {
            UnitPlayer = player;
        }

        public void Update()
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");

            UnitPlayer.Move(horizontal, 0f, vertical);
        }
    }
}