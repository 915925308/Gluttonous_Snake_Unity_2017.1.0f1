using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    public GameObject Snake;
    public Transform last;
    void Start()
    {
        string s = (int.Parse(this.name) - 1).ToString();
        last = Snake.transform.Find(s);
    }
    void Update () {
        float f = Vector2.Distance(last.position, this.transform.position);
           if (f > 0.35f)
            this.transform.Translate((last.position -this.transform.position).normalized*0.03f);
           else
            this.transform.Translate((last.position - this.transform.position).normalized * 0.02f);

    }
}
