using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS_intro_set : MonoBehaviour
{
    [SerializeField]
    AudioSource introsound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            introsound.Play();
            this.gameObject.SetActive(false);
        }

    }
}
