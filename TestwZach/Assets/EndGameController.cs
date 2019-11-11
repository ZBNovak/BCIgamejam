using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndGameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.health < 1 | enemyController.health < 1 ) {
            GameStats.BattleNum += 1; //starts at 1 




            if (enemyController.health < 1) {
                HeaderTextScript.Counter =  "YOU LOSE";
                print("YOUR SCORE" + GameStats.Score);
                //Go to end screen and display score 
            }
            else {
                HeaderTextScript.Counter = "YOU WIN";
                GameStats.Score += (playerController.health*GameStats.BattleNum);
                if (GameStats.Path > GameStats.BattleNum)
                    GameStats.Score = GameStats.Score * GameStats.Score;
                //Go to next battle

                Invoke("SwitchScenes", 5);

            }
        }

    }

    void SwitchScenes() {
        if(GameStats.Path > (GameStats.BattleNum - 1)) {
            //SceneManager.LoadScene("BossBattle", LoadSceneMode.Single);
            //Enter Loading Screen
            print("GAME OVER");
        }
        if (GameStats.Path == (GameStats.BattleNum - 1)) {
            SceneManager.LoadScene("BossBattle", LoadSceneMode.Single);
        }
        if (GameStats.BattleNum == 2) {
            SceneManager.LoadScene("Level 2", LoadSceneMode.Single);
        }
        if (GameStats.BattleNum == 3) {
            SceneManager.LoadScene("Level 3", LoadSceneMode.Single);
        }
        if (GameStats.BattleNum == 4) {
            SceneManager.LoadScene("Level 4", LoadSceneMode.Single);
        }
    }



}
