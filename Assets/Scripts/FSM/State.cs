using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State 
{
    protected BattleBehaviour battleBehaviour;
    public State(BattleBehaviour battleBehaviour){
        this.battleBehaviour = battleBehaviour;
    }
    public virtual IEnumerator StartBattle(){
        yield break;
    }
    public virtual IEnumerator Attack(){
        yield break;
    }
    public virtual IEnumerator Heal(){
        yield break;
    }
}
