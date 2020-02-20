using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruction : MonoBehaviour
{
    [SerializeField] private float destructionTime = 1.5f;

    private void Awake()
    {
        StartCoroutine(selfDestroy());
    }

    IEnumerator selfDestroy()
    {
        yield return new WaitForSeconds(destructionTime);
        Destroy(gameObject);
    }
}
