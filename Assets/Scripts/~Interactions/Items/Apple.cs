using UnityEngine;
using System.Collections;

public class Apple : Item
{
    public override void Use()
    {
        if (Character != null)
        {
            Character.HP += 10;
        }
    }
}
