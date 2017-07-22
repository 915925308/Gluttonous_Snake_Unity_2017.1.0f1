using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    private int MaxLength = 200;
    public Transform Snake;
    public Transform Head;
    public Transform Blue;
    public Transform Yellow;
    public Transform Reward;
    public Transform Reward1;
    public Transform Reward2;
    void Update () {
        int n = Snake.childCount;
        Head.Translate(Vector2.up*0.05f);
        for (int i = 1; i < n; i++ )
        {
            if((Snake.GetChild(i).position - Snake.GetChild(i - 1).position).magnitude > 0.35f){
                Snake.GetChild(i).Translate((Snake.GetChild(i-1).transform.position - Snake.GetChild(i).transform.position).normalized*0.06f);
            }else if((Snake.GetChild(i).position - Snake.GetChild(i - 1).position).magnitude > 0.03f)
            {
                Snake.GetChild(i).Translate((Snake.GetChild(i - 1).transform.position - Snake.GetChild(i).transform.position).normalized * 0.03f);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            float fl = Head.transform.eulerAngles.z;
            
            fl = fl+2f;
            Head.transform.eulerAngles = new Vector3(0, 0, fl);
        }
        if (Input.GetKey(KeyCode.D))
        {
            float fl = Head.transform.eulerAngles.z;

            fl = fl - 2f;
            Head.transform.eulerAngles = new Vector3(0, 0, fl);
        }

        if(Reward.childCount == 0)
        {

               int select = Random.Range(0, 2);
            if (select == 1)
                Instantiate(Reward1, new Vector3(Random.Range(-5, 6) * 1.0f, Random.Range(-5, 6) * 1.0f, 0),Quaternion.identity).SetParent(Reward);
            else
                Instantiate(Reward2, new Vector3(Random.Range(-5, 6) * 1.0f, Random.Range(-5, 6) * 1.0f, 0), Quaternion.identity).SetParent(Reward);
        }
    }

   
    void OnCollisionEnter2D(Collision2D col)
    {
        Transform T;
        if (col.collider.tag == "Reward")
        {
            Destroy(col.gameObject);
            int n = Snake.childCount;
            if(n%2 == 1)
            {
                T = Instantiate(Blue, Snake.GetChild(n - 1).transform.position, Quaternion.identity);
            }
            else
            {
                T = Instantiate(Yellow, Snake.GetChild(n - 1).transform.position, Quaternion.identity);
            }
            T.SetParent(Snake);
            T.name = n.ToString();
            T.gameObject.GetComponent<SpriteRenderer>().sortingOrder = MaxLength - n;
        }
    }
}
