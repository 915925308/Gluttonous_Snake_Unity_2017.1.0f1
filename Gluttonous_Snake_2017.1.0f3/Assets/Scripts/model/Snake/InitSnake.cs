using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitSnake : MonoBehaviour{

    public static InitSnake instance;

    public int Length = 3;                  //蛇的长度
    public int Score = 0;                   //蛇的得分
    public string Name;                     //蛇的名字
    public GameObject SnakeGameObject;      //蛇这个对象
    public SnakeTeams TeamType;             //蛇的队伍
    public SnakeTypes SnakeType;            //蛇的类型

    public GameObject YellowSnake;          //黄色的蛇，对象
    public GameObject RedSnake;             //红色的蛇，对象

    void Awake()
    {
        instance = this;
    }

    /// <summary>
    /// 蛇的种类
    /// </summary>
    public enum SnakeTypes
    {
        Yellow = 1,
        Red = 2
    }

    /// <summary>
    /// 蛇的队伍
    /// </summary>
    public enum SnakeTeams
    {
        Yellow = 1,
        Red = 2
    }

    /// <summary>
    /// 实例化一个蛇,名字是0到999999的数字，黄色颜色的蛇和黄色队伍的蛇
    /// </summary>
    /// <returns>返回InitSnake这个蛇类</returns>
    public InitSnake GetInstanteSnake()
    {
        string name = Random.Range(0, 999999).ToString();
        instance = GetInstanteSnake(name, 1, 1);
        return instance;
    }

    /// <summary>
    /// 实例化一个蛇
    /// </summary>
    /// <param name="name">蛇的名字</param>
    /// <param name="teamtype">蛇的队伍，1为黄色，2为红色</param>
    /// <param name="snaketype">蛇的种类，1为黄色，2为红色</param>
    /// <returns>返回InitSnake这个蛇类</returns>
    public InitSnake GetInstanteSnake(string name, int teamtype, int snaketype)
    {
        Length = 3;
        Name = name;
        Score = 0;
        if(snaketype == 1)
        {
            SnakeType = SnakeTypes.Yellow;
        }else if(snaketype == 2){
            SnakeType = SnakeTypes.Red;
        }
        
        if(teamtype == 1)
        {
            SnakeType = SnakeTypes.Yellow;
        }
        else if(teamtype == 2){
            SnakeType = SnakeTypes.Red;
        }
        SnakeGameObject = Instantiate(YellowSnake, new Vector3(0, 0, 0), Quaternion.identity);
        return instance;
    }

    public InitSnake GetInstanteSnake(Vector3 v)
    {
        Length = 3;
        Name = name;
        Score = 0;
        SnakeType = SnakeTypes.Yellow;
        TeamType = SnakeTeams.Yellow;

        SnakeGameObject = Instantiate(YellowSnake, v, Quaternion.identity);
        return instance;
    }

}
