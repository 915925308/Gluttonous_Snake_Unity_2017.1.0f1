using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyMove : MonoBehaviour {
    public GameObject Snake;
    public Transform last;
    void Start()
    {
        last = Main.lastBody.transform;
        Main.lastBody = this.gameObject;
    }
    void Update () {
        this.transform.parent.GetChild(this.transform.parent.childCount - 1);
        float f = Vector2.Distance(last.position, this.transform.position);
           if (f > 0.35f)
            this.transform.Translate((last.position -this.transform.position).normalized*0.03f);
           else
            this.transform.Translate((last.position - this.transform.position).normalized * 0.02f);

    }
}
