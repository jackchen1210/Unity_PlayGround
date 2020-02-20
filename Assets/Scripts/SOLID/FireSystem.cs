using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FireSystem : MonoBehaviour
{
    [SerializeField] private Transform spawnPos;
    [SerializeField] private float speed;

    private Ilaucnher launcher;

    // Start is called before the first frame update
    void Start()
    {
        launcher = GetComponent<Ilaucnher>();
        IPlayerMovements playerInput = GetComponent<IPlayerMovements>();
        playerInput.FireBullet += launcher.Launch;
        playerInput.FireBullet += SpawnBullet;
    }

    void SpawnBullet()
    {
       GameObject go = Instantiate(launcher.GetFireObject());
        go.transform.position = spawnPos.position;
        go.GetComponent<Rigidbody>().AddForce(transform.forward*speed);
    }
}
