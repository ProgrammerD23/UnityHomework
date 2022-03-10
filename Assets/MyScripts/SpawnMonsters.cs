using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonsters : MonoBehaviour
{
    public GameObject _monsters;
    public new Transform transform;
    private int i = 0;
    void Update()
    {
        if (i < 4)
        {
            Spawn();
            i++;
        }
    }

    private void Spawn()
    {
        Instantiate(_monsters, transform);
    }
}
