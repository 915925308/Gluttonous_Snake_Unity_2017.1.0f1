using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    
    public InitSnake MySnake;
    public GameObject head;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
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
    }
}
