using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class View : MonoBehaviour
{
    [SerializeField]private Button startBtn;
    public Button StartBtn{get;}
    [SerializeField]private Text title;
    public Text Title{get;}
    [SerializeField]private Text inputName;
    public Text InputName{get;}
}
