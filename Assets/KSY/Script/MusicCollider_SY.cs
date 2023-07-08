using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicCollider_SY : MonoBehaviour
{
    [SerializeField] private SoundControlller_SY soundController = null;
    private bool isPlayHellBGM = false;
    private bool isPlayGayagumBGM = false;
    private bool isInPlayer = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isInPlayer = true;

            CheckMusic();

            if (isPlayHellBGM || isPlayGayagumBGM)
            {
                if (soundController.audioSource.isPlaying)
                {
                    while (soundController.audioSource.volume < 1)
                    {
                        soundController.audioSource.volume += Time.deltaTime * 1.5f;
                        if (soundController.audioSource.volume >= 1) soundController.audioSource.volume = 1;
                    }
                }
                else 
                {
                    PlayMusic();
                }
            }
            else
            {
                while (soundController.audioSource.volume > 0)
                {
                    soundController.audioSource.volume -= Time.deltaTime * 1.5f;
                    if (soundController.audioSource.volume <= 0)
                    {
                        soundController.audioSource.volume = 0;
                    }
                }

                if (soundController.audioSource.volume == 0 || soundController.audioSource.clip == null || !soundController.audioSource.isPlaying)
                {
                    PlayMusic();
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isInPlayer = true;

            CheckMusic();

            if (isPlayHellBGM || isPlayGayagumBGM)
            {
                while (soundController.audioSource.volume > 0)
                {
                    soundController.audioSource.volume -= Time.deltaTime * 1.5f;
                    if (soundController.audioSource.volume <= 0)
                    {
                        soundController.audioSource.volume = 0;
                    }
                }

                if (soundController.audioSource.volume == 0) soundController.BGMStopCheck();
            }
            else { soundController.BGMStopCheck(); }
        }
    }

    private void CheckMusic()
    {
        if (soundController.audioSource.clip.name == "°¨¿ÁBGM")
        {
            isPlayHellBGM = true;
            isPlayGayagumBGM = false;
        }
        else if (soundController.audioSource.clip.name == "°¡¾ß±ÝBGM")
        {
            isPlayHellBGM = false;
            isPlayGayagumBGM = true;
        }
        else
        {
            isPlayHellBGM = false;
            isPlayGayagumBGM = false;
        }
    }

    private void PlayMusic()
    {
        if (gameObject.name == "°¨¿ÁBGM") soundController.audioSource.clip = Resources.Load<AudioClip>("Sound/°¨¿ÁBGM");
        else if (gameObject.name == "°¡¾ß±ÝBGM") soundController.audioSource.clip = Resources.Load<AudioClip>("BGM/°¡¾ß±ÝBGM");
        soundController.audioSource.volume = 1f;
        soundController.audioSource.Play();
    }
}