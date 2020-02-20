using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetting : CharecterSetting
{
    private void Awake()
    {
        health = 100;
    }

    public override void TakeDamage()
    {
        health -= 1;
    }
}
