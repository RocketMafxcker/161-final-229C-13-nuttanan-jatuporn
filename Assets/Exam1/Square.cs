using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{ 
    int side;

    private void Start()
    {
        Init("Square");
        Resize();
        side = 2;
        Debug.Log($"side of Square: {side}");
        Debug.Log($"area of Square: {CalculateArea()}");
    }
    public override float CalculateArea()
    {
        float area = side * side;
        return area;
    }
    public override void Resize()
    {
        Debug.Log($"{shapeName} Resized");
    }
}
