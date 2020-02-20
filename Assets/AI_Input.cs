using System.Collections;
using UnityEngine;
using System;
using Random = UnityEngine.Random;


public class AI_Input : MonoBehaviour,IPlayerMovements
{
    public float Horizontal { get; set; }
    public float Vertical { get; set; }
    public bool Fire { get; set; }

    public event Action FireBullet = delegate { };

    [SerializeField] private float movingTime = 1.5f;

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= movingTime)
        {
            Debug.Log("AI moving");
            Moving();
            movingTime += Time.time;
        }
    }

     private void Moving()
    {
        Horizontal = Random.Range(-1,1);
        Vertical = Random.Range(-1,1);
    }
}
