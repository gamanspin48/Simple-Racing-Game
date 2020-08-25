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
            isRight = !isRight;
            ChangePosition();
         }
    }

    public void ChangePosition(){
        if(isRight)
            transform.position = leftPos.position;
        else
            transform.position = rightPos.position;

    }

}
