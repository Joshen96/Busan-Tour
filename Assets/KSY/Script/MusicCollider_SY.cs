using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicCollider_SY : MonoBehaviour
{
    [SerializeField] private float BGM_volume = 1.0f;
    [SerializeField] private SoundControlller_SY soundController = null;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            while (other.GetComponent<AudioSource>().volume > 0)
            {
                other.GetComponent<AudioSource>().volume -= Time.deltaTime / 1.5f; // 1.5초동안 볼륨을 0으로 만든다.

                if (other.GetComponent<AudioSource>().volume <= 0)
                {
                    other.GetComponent<AudioSource>().volume = 0;
                    other.GetComponent<AudioSource>().Pause();

                    other.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>("Sound/" + gameObject.name);
                    other.GetComponent<AudioSource>().Play();
                    other.GetComponent<AudioSource>().volume = BGM_volume;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            while (other.GetComponent<AudioSource>().volume > 0)
            {
                other.GetComponent<AudioSource>().volume -= Time.deltaTime / 1.5f;
            }
            if (other.GetComponent<AudioSource>().volume <= 0)
            {
                other.GetComponent<AudioSource>().volume = 0;
                other.GetComponent<AudioSource>().Pause();

                if (soundController.beachToggle.isOn)
                {
                    soundController.SetBeachBGM(true);
                }
                else if (soundController.seaToggle.isOn)
                {
                    soundController.SetSeaBGM(true);
                }
                else if (soundController.freshToggle.isOn)
                {
                    soundController.SetFreshBGM(true);
                }
                else if (soundController.coolToggle.isOn)
                {
                    soundController.SetCoolBGM(true);
                }
                other.GetComponent<AudioSource>().volume = 1;
            }
        }
    }
}