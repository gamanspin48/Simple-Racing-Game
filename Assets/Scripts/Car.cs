using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Transform rightPos;
    public Transform leftPos;
    public bool isRight;   

    // Update is called once per frame
    void Update(){
            if (Input.GetMouseButtonDown(0)){ // if left button pressed...
                if (!SceneManager.Instance.isGameOver){
                    isRight = !isRight;
                    ChangePosition();
                }else{
                    SceneManager.Instance.isGameOver = false;
                    SceneManager.Instance.score = 0;
                    SceneManager.Instance.papan.Reset();
                    SceneManager.Instance.keterangan.gameObject.SetActive(false);
                }  
            }
        
    }

    public void ChangePosition(){
        if(isRight)
            transform.position = leftPos.position;
        else
            transform.position = rightPos.position;

    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag=="papan"){
            Debug.Log("Game Over");
            SceneManager.Instance.isGameOver = true;
        }else if (other.tag == "lolos"){
            SceneManager.Instance.score += 1;
            SceneManager.Instance.UpdateScore(); 
            SceneManager.Instance.velocity += 0.1f;
        }
    }

}
