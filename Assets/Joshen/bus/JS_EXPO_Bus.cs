using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS_EXPO_Bus : MonoBehaviour
{/*
    [SerializeField]
    private GameObject bus;

    [SerializeField]
    private Transform player;

    public Transform[] paths;

    [SerializeField]
    private float moveTime=0f;
    
    public float scrPlayDist = 8f;


    public int cnt = 0;
    private void Awake()
    {
        bus.transform.position = paths[0].transform.position;
        
    }
    private void Update()
    {
        moveTime = bus.gameObject.GetComponentInChildren<JS_bus_speed>().moveTime;

        float dist = CalcDistanceWithTarget();

        if(dist < scrPlayDist)
        {
            
        }


    }

    private float CalcDistanceWithTarget()
    {
        Vector3 dirToTarget =
            player.position - bus.transform.position;
        float dist = dirToTarget.magnitude;

        dist = Vector3.Distance(
            player.position, bus.transform.position);

        return dist;
    }





















    public void movetonextpos(Transform nowpath, Transform nextpath)
    {
        StartCoroutine(MoveTo(nowpath,nextpath));
    }

    private IEnumerator MoveTo(Transform nowpath,Transform nextpath)
    {

         //½Ã

        
        
    }
    public void turnBus(Transform _nextpath)
    {
        Vector3 dir = _nextpath.transform.position - bus.transform.position;
        bus.gameObject.transform.rotation = Quaternion.Lerp(bus.transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * 10f);

    }*/
}
