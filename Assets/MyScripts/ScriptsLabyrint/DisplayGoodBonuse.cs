using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Maze
{
    public class DisplayGoodBonuse
    {
        private Text bonuseLable;

        public DisplayGoodBonuse(GameObject bonuse)
        {
            bonuseLable = bonuse.GetComponentInChildren<Text>();
            bonuseLable.text = string.Empty;
        }

        public void Display(int value)
        {
            bonuseLable.text = $"Вы набрали {value}";
        }

    }
}
