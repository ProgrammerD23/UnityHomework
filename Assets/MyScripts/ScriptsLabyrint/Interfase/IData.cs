using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISave
{
    void Save(SaveData bonus);
    SaveData Load();
}
