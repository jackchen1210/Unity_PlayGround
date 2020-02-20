using System.Collections;
using UnityEngine;
public class Start :State 
{   
    public Start(StateDesignPattern battleBehaviour):base(battleBehaviour){

    }

    public override IEnumerator StartState(){
        Debug.Log("Start");
        yield return null;
        battleBehaviour.SetState(new Running(battleBehaviour));
    }


}