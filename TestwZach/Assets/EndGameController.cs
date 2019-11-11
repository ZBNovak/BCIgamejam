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




            if (playerController.health < 1) {
                HeaderTextScript.Counter =  "YOU LOSE";
                print("YOUR SCORE" + GameStats.Score);
                //Go to end screen and display score
                SceneManager.LoadScene("End Scene Lose", LoadSceneMode.Single);
            }
            else {
                HeaderTextScript.Counter = "YOU WIN";
                GameStats.Score += (playerController.health*GameStats.BattleNum);
                if (GameStats.Path > GameStats.BattleNum)
                    GameStats.Score = GameStats.Score * GameStats.Score;
                //Go to next battle

                print("invoking");
                //Invoke("SwitchScenes", 5f);
                SwitchScenes();
            }
        }

    }

    void SwitchScenes() {
        if(GameStats.Path > (GameStats.BattleNum - 1)) {
            //SceneManager.LoadScene("BossBattle", LoadSceneMode.Single);
            //Enter Loading Screen
            print("GAME OVER");
            SceneManager.LoadScene("End Scene Win", LoadSceneMode.Single);
        }
        if (GameStats.Path == (GameStats.BattleNum - 1)) {
            print("Switching to Boss Battle");
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
