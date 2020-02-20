using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private IPlayerMovements PlayerInput;

    // Start is called before the first frame update
    void Start()
    {
        PlayerInput = GetComponent<IPlayerMovements>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moving = new Vector3(PlayerInput.Horizontal, 0, PlayerInput.Vertical);
        //transform.position += moving;
        transform.Translate(moving);
    }
}
