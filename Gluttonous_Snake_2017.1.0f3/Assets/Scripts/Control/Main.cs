using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    [HideInInspector]
    public InitSnake MySnake;
    [HideInInspector]
    public GameObject head;
    public static GameObject lastBody;
	void Start () {
        
    }
	
	void Update () {
        if (MySnake != null)
        {
            Controler_Snake.ControlTurn(head);
        }
    }

    public void GetInstanteSnake()
    {
        MySnake = InitSnake.instance.GetInstanteSnake();
        head = MySnake.SnakeGameObject.transform.GetChild(0).gameObject;
        lastBody = MySnake.SnakeGameObject.transform.GetChild(0).gameObject;
    }

    public void Add()
    {
        InitSnake.instance.ExpandSnake(MySnake);
    }
}
