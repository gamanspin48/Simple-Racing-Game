using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{   
    public GameObject lolos;
    public Transform spawnPositionRight;
    public Transform spawnPositionLeft;
    public GameObject destroyPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 curPos = transform.position;
        curPos.y -= SceneManager.Instance.velocity;
        transform.position = curPos;
    }

     void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject==destroyPosition){
            int flipVal = Random.Range(0,2);
            if (flipVal == 0){
                transform.position = spawnPositionRight.position;
                lolos.transform.position = spawnPositionLeft.transform.position;
            }else{
                transform.position = spawnPositionLeft.position;
                lolos.transform.position = spawnPositionRight.transform.position;
            }
            
           
        }
    }

}
