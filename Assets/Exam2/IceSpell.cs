using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    // Start is called before the first frame update
    void Start()
    {
        Cast();
        Cast("Slime");
        Cast("Slime", 15);
    }

    public override void Cast()
    {
        Debug.Log("Ice Freeze Them All");
    }
}
