using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public Transform spawnPosition;
    public GameObject destroyPosition;
    public bool isRandom;
    public Sprite[] otherSprites;

    void Update(){
        Vector3 curPos = transform.position;
        curPos.y -= SceneManager.Instance.velocity;
        transform.position = curPos;
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject==destroyPosition){
            Vector3 curPos = spawnPosition.position;
            transform.position = curPos;
            if (isRandom){
                int index = Random.Range(0,3);
                GetComponent<SpriteRenderer>().sprite = otherSprites[index];
            }
        }
    }

}
