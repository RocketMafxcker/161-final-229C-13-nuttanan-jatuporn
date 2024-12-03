using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName;

    public void Init(string newName)
    {
        shapeName = newName;
        Draw();
        Resize();
    }
    public abstract float CalculateArea();
    public virtual void Resize()
    {
        Debug.Log($"Resizing the {shapeName}.......");
    }
    public void Draw()
    {
        Debug.Log($"Drawing {shapeName}");
    }
}
