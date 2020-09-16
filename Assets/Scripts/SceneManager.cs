using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{   
    public float velocity;
    public int score;
    public Text scoreText;
    public bool isGameOver;
    public Text keterangan;
    public Obstacle papan;
    public Button btnRetry;
    public Button btnCloseAd;
    public bool isStart;
    public VungleScript ads;

    public static SceneManager Instance { get; private set; } // static singleton
    void Awake() {
         if (Instance == null) { Instance = this;  }
         else { Destroy(gameObject); }
         // Cache references to all desired variables
        //  player= FindObjectOfType<Player>();
     }

     public void UpdateScore(){
          scoreText.text = "Score : "+ score;
     }

     public void GameOver(){
          isGameOver = true;
          keterangan.gameObject.SetActive(true);
          keterangan.text = "Game Over";
          btnRetry.gameObject.SetActive(true);
          btnCloseAd.gameObject.SetActive(true);
          ads.ShowAd();
    }


     public void Reset(){
          isGameOver = false;
          score = 0;
          papan.Reset();
           btnRetry.gameObject.SetActive(false);
          keterangan.gameObject.SetActive(false);
          scoreText.text = "Score : 0";
          velocity = 10;
     }


}
