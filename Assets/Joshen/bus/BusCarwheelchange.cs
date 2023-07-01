using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BusCarwheelchange : MonoBehaviour
{
    
    public GameObject[] wheels;
    public GameObject CarspeedControl;
    public float xspeed = 180;
    bool isstop=false;

   
    // Update is called once per frame
    void Update()
    {
        if (isstop) 
        {
            foreach (GameObject wheel in wheels)
            {
                wheel.transform.Rotate(0, 0, 0);
            }
        }
        else {
            foreach (GameObject wheel in wheels)
            {
                wheel.transform.Rotate(0, xspeed * Time.deltaTime, 0);
            }
        }

    }
    public void Stop()
    {
        isstop = true;
    }
    public void Go()
    {
        isstop = false;
    }

}
