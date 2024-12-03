using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cricle : Shape
{
    float raidus;
    private void Start()
    {
        Init("Cricle");
        Resize();
        raidus = 2;
        Debug.Log($"raidus of Circle: {raidus}");
        Debug.Log($"area of Circle: {CalculateArea()}");
    }
    public override float CalculateArea()
    {
        float area = 3.14f * raidus * raidus;
        return area;
    }
    public override void Resize()
    {
        Debug.Log("Cricle in Class");
    }
}
