using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFSM : MonoBehaviour
{
    [SerializeField]private State state=new State();
    private enum State{

        START,
        RUNNING,
        PAUSE,
        END,
    }

    private void Start() {
        StartCoroutine(GameStart());
    }

    private IEnumerator GameStart(){
        Debug.Log("GameStart");
        yield return new WaitForSeconds(1);
        if(state==State.RUNNING){
            StartCoroutine(GameRunning());
        }else{
            StartCoroutine(GameStart());
        }
        
    }
    private IEnumerator GameRunning(){
        Debug.Log("GameRunning");
        yield return null;
        StartCoroutine(GameRunning());
    }
    private IEnumerator GamePause(){
        Debug.Log("GamePause");
        yield return null;
    }
    private IEnumerator GameEnd(){
        Debug.Log("GameEnd");
        yield return null;
    }

}
