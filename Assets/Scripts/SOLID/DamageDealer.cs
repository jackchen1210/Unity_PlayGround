using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DamageDealer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            CharecterSetting nearestCharecter = FindObjectsOfType<CharecterSetting>()
                .OrderBy((t) => Vector3.Distance(transform.position, t.transform.position))
                .FirstOrDefault();

            nearestCharecter.TakeDamage();
        }
    }
}
