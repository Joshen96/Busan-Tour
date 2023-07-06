using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicCollider_SY : MonoBehaviour
{
    [SerializeField] private float BGM_volume = 1.0f;
    [SerializeField] private SoundControlller_SY soundController = null;
    [SerializeField] private Sound_xrinter_SY soundXrinter = null;
    [SerializeField] private GameObject colliderUI = null;
    [SerializeField] private GameObject defaultUI = null;

    private void Awake()
    {
        if (!soundController) soundController = GameObject.FindWithTag("SoundController").GetComponent<SoundControlller_SY>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            while (other.GetComponent<AudioSource>().volume > 0)
            {
                other.GetComponent<AudioSource>().volume -= Time.deltaTime * 1.5f;

                if (other.GetComponent<AudioSource>().volume <= 0)
                {
                    other.GetComponent<AudioSource>().volume = 0;
                    other.GetComponent<AudioSource>().Pause();
                }
            }

            if (gameObject.name == "드론쇼콜라이더")
            {
                soundXrinter.soundUI = colliderUI;
                soundController.SetElectronicBGM(true);
                soundController.SetVolume(1);
            }
            else if (gameObject.name == "어방축제콜라이더")
            {
                soundXrinter.soundUI = colliderUI;
                // soundController.SetElectronicBGM(true); (-)
                soundController.SetVolume(1);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            while (other.GetComponent<AudioSource>().volume > 0)
            {
                other.GetComponent<AudioSource>().volume -= Time.deltaTime * 1.5f;

                if (other.GetComponent<AudioSource>().volume <= 0)
                {
                    other.GetComponent<AudioSource>().volume = 0;
                    other.GetComponent<AudioSource>().Pause();
                }
            }
            soundXrinter.soundUI = defaultUI;
            if (soundController.seaToggle.isOn) soundController.SetSeaBGM(true);
            else if (soundController.beachToggle.isOn) soundController.SetBeachBGM(true);
            else if (soundController.coolToggle.isOn) soundController.SetCoolBGM(true);
            else if (soundController.freshToggle.isOn) soundController.SetFreshBGM(true);

            soundController.SetVolume(1);
        }
    }
}