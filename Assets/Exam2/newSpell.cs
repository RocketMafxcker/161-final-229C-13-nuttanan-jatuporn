using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newSpell : Spell
{
    void Start()
    {
        Cast();
        Cast("Slime");
        Cast("Slime", 100);
    }

    public override void Cast()
    {
        Debug.Log("Shoot Bullet To Them");
    }
}
