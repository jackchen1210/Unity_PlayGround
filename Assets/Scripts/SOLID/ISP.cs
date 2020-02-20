using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ISP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


class Player1 : IState
{
   public int STR { get; }
   public int health { get; }
}

class Door : IHealth
{
    public int health { get; }
}


interface IState : IHealth
{
    int STR { get; }
}

interface IHealth
{
    int health { get; }
}