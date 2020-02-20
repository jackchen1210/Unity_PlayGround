using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State 
{
    protected StateDesignPattern battleBehaviour;
    public State(StateDesignPattern battleBehaviour){
        this.battleBehaviour = battleBehaviour;
    }
    public virtual IEnumerator StartState(){
        Debug.Log("No State");
        yield return null;
    }
}
