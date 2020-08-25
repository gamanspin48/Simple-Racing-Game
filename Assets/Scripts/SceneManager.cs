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

     public void KeteranganGameOver(){
          scoreText.gameObject.SetActive(true);
          scoreText.text = "Game Over \n (Tap To Start)";
     }


}
