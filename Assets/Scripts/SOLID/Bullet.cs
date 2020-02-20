
using UnityEngine;

public class Bullet : MonoBehaviour ,Ilaucnher
{
    [SerializeField] private GameObject bulletPrefab;


    public void Launch()
    {
        Debug.Log("bulletPrefab");
    }

    public GameObject GetFireObject()
    {
        return bulletPrefab;
    }
}
