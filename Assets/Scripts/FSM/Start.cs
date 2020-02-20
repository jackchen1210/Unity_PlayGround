using System.Collections;
using UnityEngine;
public class Start :State 
{   
    public Start(BattleBehaviour battleBehaviour):base(battleBehaviour){

    }

    public override IEnumerator StartBattle(){
        Debug.Log(battleBehaviour.BattleLog);
        yield break;
    }
}