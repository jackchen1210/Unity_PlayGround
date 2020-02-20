using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerInput : MonoBehaviour,IPlayerMovements
{
    public float Horizontal { get; set; }

    public float Vertical { get; set; }

    public bool Fire { get; set; }

    public event Action  FireBullet = delegate { };

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        Fire = Input.GetKeyDown(KeyCode.Space);

        if (Fire)
        {
            FireBullet();
        }

    }
}
