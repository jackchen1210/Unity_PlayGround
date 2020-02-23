using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]public class StringEvent: UnityEvent<string>{}
public class Controller : MonoBehaviour
{
    [SerializeField]private StringEvent playerNameSet;
    [SerializeField]private StringEvent playerNameGet;
    public string playerName{get;set;}
    // Start is called before the first frame update
    private void Start()
    {
        if(PlayerPrefs.HasKey("playerName")){
            playerNameGet?.Invoke("Welcome Back,"+PlayerPrefs.GetString("playerName"));
        }
    }

    public void SetPlayerName(){
        PlayerPrefs.SetString("playerName",playerName);
        playerNameSet?.Invoke("Hi,"+playerName);
    }
}
