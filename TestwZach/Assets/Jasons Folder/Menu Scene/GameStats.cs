using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStats : MonoBehaviour
{
    public static int BattleNum;
    public static int Score;
    public static int Path; //for setting number of battles to take place

    private void Start() {
        BattleNum = 1;
        Score = 0;
    }


    /*
     private static int battleNum;

    public static int BattleNum
    {
        get
        {
            return battleNum;
        }
        set
        {
            battleNum = value;
        }
    }
    */
}
