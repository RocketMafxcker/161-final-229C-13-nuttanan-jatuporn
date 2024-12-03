using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    // Start is called before the first frame update
    void Start()
    {
        Cast();
        Cast("Slime");
        Cast("Slime", 30);
    }

    public override void Cast()
    {
        Debug.Log("Shot Fireball To Them");
    }
}
