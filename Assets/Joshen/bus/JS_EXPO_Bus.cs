using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS_EXPO_Bus : MonoBehaviour
{
    [SerializeField]
    private GameObject bus;
    [SerializeField]
    private Transform player;
    public Transform[] paths;
    [SerializeField]
    private float moveTime;

    public float current;
    public float percent;
    [SerializeField]
    AnimationCurve moveCurve;

    public int cnt = 0;
    private void Awake()
    {
        
        StartCoroutine(nameof(MoveTo));
    }
    private void Update()
    {
        //turnBus(paths[cnt+1]);
    }


    private IEnumerator MoveTo()
    {
        bus.transform.position = paths[0].transform.position;



        while (true)
        {
            current = 0f;
            percent = 0f;
            while (percent < 1)
            {

                current += Time.deltaTime;
                percent = current / moveTime;

                bus.transform.position = Vector3.Lerp(paths[cnt].transform.position, paths[cnt + 1].position, moveCurve.Evaluate(percent));
                if (percent > 0.8)
                { 
                    if(cnt==4)
                    {
                        cnt = 0;
                    }
                    turnBus(paths[cnt + 2]);
                    
                }

                yield return null;

            }
            cnt++;
            if (cnt >= paths.Length-1)
            {
                cnt = 0;
            }

        }
        
    }
    public void turnBus(Transform _nextpath)
    {
        Vector3 dir = _nextpath.transform.position - bus.transform.position;
        bus.gameObject.transform.rotation = Quaternion.Lerp(bus.transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * 5f);

    }
}
