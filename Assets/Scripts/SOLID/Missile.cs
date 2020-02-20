using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour,Ilaucnher
{
    [SerializeField] private GameObject missilePrefab;


    public void Launch()
    {
        Debug.Log("missilePrefab");
    }

    public GameObject GetFireObject()
    {
        return missilePrefab;
    }
}
