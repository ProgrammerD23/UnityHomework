using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Testing
{
    public static class ExtensionMethods
    {
        public static void CountsCharacters(this string text)
        {
            
             Debug.Log(text.Length.ToString());
        }
    }
}