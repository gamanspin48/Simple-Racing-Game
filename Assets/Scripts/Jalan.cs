using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jalan : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {   
        Vector3 curPos = transform.position;
        curPos.y -= SceneManager.Instance.velocity;
        transform.position = curPos;
    }
}
