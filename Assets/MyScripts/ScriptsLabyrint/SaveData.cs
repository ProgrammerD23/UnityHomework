using System;
using UnityEngine;

[Serializable]
public sealed class SaveData
{
    public string Name;
    public SVect3 Position;
    public bool IsEnabled;

    public override string ToString() => $"Name {Name} Position {Position}IsVisible {IsEnabled}";
}


[Serializable]
public struct SVect3
{
    public float X;
    public float Y;
    public float Z;

    private SVect3(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }


    public static implicit operator SVect3(Vector3 vaule)
    {
        return new SVect3(vaule.x, vaule.y, vaule.z);
    }

    public static implicit operator Vector3(SVect3 vaule)
    {
        return new SVect3(vaule.X, vaule.Y, vaule.Z);
    }

    public override string ToString() => $" (X = {X} Y = {Y} Z = {Z})";

}
