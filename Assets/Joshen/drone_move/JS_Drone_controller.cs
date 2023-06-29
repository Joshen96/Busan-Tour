using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS_Drone_controller : MonoBehaviour
{
    [SerializeField]
    [Range(10f, 50f)]
    private float moveSpeed = 10f;
    [SerializeField, Range(50f, 100f)]
    private float rotSpeed = 50f;
    // Class Member Variables
    private Transform tr = null;
    private Rigidbody rb = null;

    private void Awake()
    {
        tr = GetComponent<Transform>();
        //tr = transform;
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        
    }


   public void front()
    {
        rb.velocity = tr.forward * moveSpeed;
    }
   public void back() 
    {
        rb.velocity = tr.forward * -moveSpeed;
    }

    public void left_turn()
    {
        Vector3 newRot = tr.rotation.eulerAngles;
        newRot.y -= rotSpeed * Time.deltaTime;
        tr.rotation = Quaternion.Euler(newRot);
    }
    public void right_turn() 
    {
        // Function Overloading
        tr.Rotate(Vector3.up,
                  rotSpeed * Time.deltaTime);
    }


}
