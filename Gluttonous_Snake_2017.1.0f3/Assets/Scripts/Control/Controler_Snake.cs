using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler_Snake : MonoBehaviour {

    public static float TurnSpeed = 2f;
    public static float f = 0;
    public static void ControlTurn(GameObject snakeHead)
    {
        f = snakeHead.transform.eulerAngles.z;
        if (Input.GetKey(KeyCode.A))
            {     
                f = f + TurnSpeed;
                snakeHead.transform.eulerAngles = new Vector3(0, 0, f);
            }

            if (Input.GetKey(KeyCode.D))
            {
                float fl = snakeHead.transform.eulerAngles.z;
                fl = fl - TurnSpeed;
                snakeHead.transform.eulerAngles = new Vector3(0, 0, fl);
            }
            if(Input.GetKey(KeyCode.W))
        {
            Destroy(snakeHead);
        }
    }
 }
