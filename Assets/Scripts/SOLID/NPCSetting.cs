using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSetting : CharecterSetting
{
    private void Awake()
    {
        health = 100;
    }

    public override void TakeDamage()
    {
        health -= 5;
    }
}
