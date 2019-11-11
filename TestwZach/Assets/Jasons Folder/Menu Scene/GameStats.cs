using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStats : MonoBehaviour
{
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

}
