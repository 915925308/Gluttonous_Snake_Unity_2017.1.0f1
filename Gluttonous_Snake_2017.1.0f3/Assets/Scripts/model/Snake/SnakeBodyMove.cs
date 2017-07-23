using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeBodyMove : MonoBehaviour {

    private Transform PreBody;
	// Use this for initialization
	void Start () {
        InitSnake initsnake = GameObject.Find("Manage").GetComponent<Main>().MySnake;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
