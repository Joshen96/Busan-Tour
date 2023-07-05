using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundControlller_SY : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource = null;
    [SerializeField] private Slider slider = null;
    private float preSoundVolume = 0;

    [SerializeField] private Toggle seaToggle = null;
    [SerializeField] private Toggle beachToggle = null;
    [SerializeField] private Toggle freshToggle = null;
    [SerializeField] private Toggle coolToggle = null;

    private void Awake()
    {
        if (!audioSource) audioSource = GameObject.FindWithTag("Player").GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (!seaToggle.isOn && !beachToggle.isOn && !freshToggle.isOn && !coolToggle.isOn) seaToggle.isOn = true;
    }

    public void SetVolume(float _volume)            // 음량 슬라이더에 들어갈 이벤트
    {
        audioSource.volume = _volume;
    }

    public void SetMute(bool _check)           // 음소거 토글에 들어갈 이벤트
    {
        if (_check)
        {
            preSoundVolume = audioSource.volume;
            audioSource.volume = 0f;
        }
        else
        {
            if (audioSource.volume == 0f) audioSource.volume = preSoundVolume;
        }
    }

    public void SetSeaBGM(bool _check)
    {
        if (_check)
        {
            if (audioSource.clip.name != "바다느낌BGM" && audioSource.clip.name != "산뜻한느낌BGM" && audioSource.clip.name != "시원한느낌BGM" && audioSource.clip.name != "해변느낌BGM")
            {
                _check = false;
                return;
            }
            else
            {
                switch (audioSource.clip.name)
                {
                    case "바다느낌BGM":
                        {  seaToggle.isOn = true;  }
                        return;
                    case "산뜻한느낌BGM":
                        { freshToggle.isOn = false;  }
                        break;
                    case "시원한느낌BGM":
                        { coolToggle.isOn = false; }
                        break;
                    case "해변느낌BGM":
                        { beachToggle.isOn = false; }
                        break;
                }
                audioSource.Pause();
                audioSource.clip = Resources.Load<AudioClip>("BGM/" + "바다느낌BGM");
                audioSource.Play();
            }
        }
    }
    public void SetBeachBGM(bool _check)
    {
        if (_check)
        {
            if (audioSource.clip.name != "바다느낌BGM" && audioSource.clip.name != "산뜻한느낌BGM" && audioSource.clip.name != "시원한느낌BGM" && audioSource.clip.name != "해변느낌BGM")
            {
                _check = false;
                return;
            }
            else
            {
                switch (audioSource.clip.name)
                {
                    case "바다느낌BGM":
                        { seaToggle.isOn = false; }
                        break;
                    case "산뜻한느낌BGM":
                        { freshToggle.isOn = false; }
                        break;
                    case "시원한느낌BGM":
                        { coolToggle.isOn = false; }
                        break;
                    case "해변느낌BGM":
                        { beachToggle.isOn = true; }
                        return;
                }
                audioSource.Pause();
                audioSource.clip = Resources.Load<AudioClip>("BGM/" + "해변느낌BGM");
                audioSource.Play();
            }
        }
    }
    public void SetFreshBGM(bool _check)
    {
        if (_check)
        {
            if (audioSource.clip.name != "바다느낌BGM" && audioSource.clip.name != "산뜻한느낌BGM" && audioSource.clip.name != "시원한느낌BGM" && audioSource.clip.name != "해변느낌BGM")
            {
                _check = false;
                return;
            }
            else
            {
                switch (audioSource.clip.name)
                {
                    case "바다느낌BGM":
                        { seaToggle.isOn = false; }
                        break;
                    case "산뜻한느낌BGM":
                        { freshToggle.isOn = true; }
                        return;
                    case "시원한느낌BGM":
                        { coolToggle.isOn = false; }
                        break;
                    case "해변느낌BGM":
                        { beachToggle.isOn = false; }
                        break;
                }
                audioSource.Pause();
                audioSource.clip = Resources.Load<AudioClip>("BGM/" + "산뜻한느낌BGM");
                audioSource.Play();
            }
        }
    }
    public void SetCoolBGM(bool _check)
    {
        if (_check)
        {
            if (audioSource.clip.name != "바다느낌BGM" && audioSource.clip.name != "산뜻한느낌BGM" && audioSource.clip.name != "시원한느낌BGM" && audioSource.clip.name != "해변느낌BGM")
            {
                _check = false;
                return;
            }
            else
            {
                switch (audioSource.clip.name)
                {
                    case "바다느낌BGM":
                        { seaToggle.isOn = false; }
                        break;
                    case "산뜻한느낌BGM":
                        { freshToggle.isOn = false; }
                        break;
                    case "시원한느낌BGM":
                        { coolToggle.isOn = true; }
                        return;
                    case "해변느낌BGM":
                        { beachToggle.isOn = false; }
                        break;
                }
                audioSource.Pause();
                audioSource.clip = Resources.Load<AudioClip>("BGM/" + "시원한느낌BGM");
                audioSource.Play();
            }
        }
    }
}
