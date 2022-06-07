using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Maze
{
    public class DisplayEndGame
    {
        private Text finishLable;

        public DisplayEndGame(GameObject bonuse)
        {
            finishLable = bonuse.GetComponentInChildren<Text>();
            finishLable.text = string.Empty;
        }

        public void GameOver(string name)
        {
            finishLable.text = $"Вы проиграли: имя бонуса {name}";
        }

    }
}