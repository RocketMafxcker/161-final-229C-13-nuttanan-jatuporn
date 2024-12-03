using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Spell Script Start");
        Cast();
    }
    public virtual void Cast()
    {
        Debug.Log("Cast a all spell!");
    }
    public void Cast(string target)
    {
        Debug.Log($"Target is {target}");
    }
    public void Cast(string target, int dmg)
    {
        Debug.Log($"{target} took dmg: {dmg}");
    }

}