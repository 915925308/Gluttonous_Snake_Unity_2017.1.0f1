using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    public GameObject YellowSnake;
    public GameObject RedSnake;
    public InitSnake MySnake;
	// Use this for initialization
	void Start () {
        MySnake = InitSnake.GetInstanteSnake();
        if(MySnake.SnakeType == InitSnake.SnakeTypes.Yellow)
        {
            MySnake.SnakeGameObject = Instantiate(YellowSnake, new Vector3(0, 0, 0), Quaternion.identity);
            MySnake.SnakeGameObject.name = MySnake.Name;
        }
        
        
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(MySnake);
    }

    public void GetInstanteSnake()
    {
        MySnake = InitSnake.GetInstanteSnake();
    }
}
