using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector2.up.normalized * 0.03f);
	}
}
