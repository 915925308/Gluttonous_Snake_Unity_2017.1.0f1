using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitSnake{

    public static InitSnake Snake;
    
    public int Length = 3;
    public int Score = 0;
    public string Name;
    public GameObject SnakeGameObject;
    public SnakeTeams TeamType;
    public SnakeTypes SnakeType;

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
    public static InitSnake GetInstanteSnake()
    {
        Snake = new InitSnake();
        string name = Random.Range(0, 999999).ToString();
        Snake = GetInstanteSnake(name, 1, 1);
        return Snake;
    }

    /// <summary>
    /// 实例化一个蛇
    /// </summary>
    /// <param name="name">蛇的名字</param>
    /// <param name="teamtype">蛇的队伍，1为黄色，2为红色</param>
    /// <param name="snaketype">蛇的种类，1为黄色，2为红色</param>
    /// <returns>返回InitSnake这个蛇类</returns>
    public static InitSnake GetInstanteSnake(string name, int teamtype, int snaketype)
    {
        Snake = new InitSnake();
        Snake.Name = name;
        if(snaketype == 1)
        {
            Snake.SnakeType = SnakeTypes.Yellow;
        }else if(snaketype == 2){
            Snake.SnakeType = SnakeTypes.Red;
        }
        
        if(teamtype == 1)
        {
            Snake.SnakeType = SnakeTypes.Yellow;
        }else if(teamtype == 2){
            Snake.SnakeType = SnakeTypes.Red;
        }
        return Snake;
    }

    
}
