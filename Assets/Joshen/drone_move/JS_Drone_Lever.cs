using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS_Drone_Lever : MonoBehaviour
{
    public JS_Drone_controller drone;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name=="front")
        {
            drone.front();
        }
        if(collision.gameObject.name=="back")
        {
            drone.back();
        }
        if( collision.gameObject.name=="left")
        {
            drone.left_turn();
        }
        if( collision.gameObject.name=="right")
        {
            drone.right_turn();
        }
    }
}
