using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS_Arrow_hit : MonoBehaviour
{
    [SerializeField]
    ParticleSystem core;//Á¡¼ö
    

    private void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("ArrowTip"))
        {
            core.Play();
        }
    }

}
