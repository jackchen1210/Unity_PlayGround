using UnityEngine;
using System.Collections;

public class Running : State {
    public Running(StateDesignPattern battleBehaviour):base(battleBehaviour){

    }

    public override IEnumerator StartState(){
        Debug.Log(battleBehaviour.BattleLog);
        yield return new WaitForSeconds(1);
        battleBehaviour.SetState(new Running(battleBehaviour));
    }
}