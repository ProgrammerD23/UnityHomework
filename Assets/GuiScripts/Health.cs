using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private float minValue = 0f;
    private void OnGUI()
    {
        GUI.TextArea(new Rect(0, 10, 100, 20), "Жизни: 100%");

    }
}
