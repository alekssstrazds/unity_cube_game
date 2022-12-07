using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    public float moveX = 0.0f;
    public bool changeWay = false;
    GameObject movedWall;
    void Start()
    {
        movedWall = GameObject.FindWithTag("MovedWall");
    }

    void Update()
    {
        if(movedWall.transform.position.x != 3 && changeWay == false) {
            moveX += 0.5f * Time.deltaTime;
            movedWall.transform.position = new Vector3(moveX,1,0);
            if(movedWall.transform.position.x == 3) {
                changeWay = true;
            }    
        }
        if(movedWall.transform.position.x != -3 && changeWay == true) {
            moveX -= 0.5f * Time.deltaTime;
            movedWall.transform.position = new Vector3(moveX,1,0);
            if(movedWall.transform.position.x == -3) {
                changeWay = false;
            }  
        }
    }
}
