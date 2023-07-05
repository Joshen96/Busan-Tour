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

    public void SetVolume(float _volume)            // ���� �����̴��� �� �̺�Ʈ
    {
        audioSource.volume = _volume;
    }

    public void SetMute(bool _check)           // ���Ұ� ��ۿ� �� �̺�Ʈ
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
            if (audioSource.clip.name != "�ٴٴ���BGM" && audioSource.clip.name != "����Ѵ���BGM" && audioSource.clip.name != "�ÿ��Ѵ���BGM" && audioSource.clip.name != "�غ�����BGM")
            {
                _check = false;
                return;
            }
            else
            {
                switch (audioSource.clip.name)
                {
                    case "�ٴٴ���BGM":
                        {  seaToggle.isOn = true;  }
                        return;
                    case "����Ѵ���BGM":
                        { freshToggle.isOn = false;  }
                        break;
                    case "�ÿ��Ѵ���BGM":
                        { coolToggle.isOn = false; }
                        break;
                    case "�غ�����BGM":
                        { beachToggle.isOn = false; }
                        break;
                }
                audioSource.Pause();
                audioSource.clip = Resources.Load<AudioClip>("BGM/" + "�ٴٴ���BGM");
                audioSource.Play();
            }
        }
    }
    public void SetBeachBGM(bool _check)
    {
        if (_check)
        {
            if (audioSource.clip.name != "�ٴٴ���BGM" && audioSource.clip.name != "����Ѵ���BGM" && audioSource.clip.name != "�ÿ��Ѵ���BGM" && audioSource.clip.name != "�غ�����BGM")
            {
                _check = false;
                return;
            }
            else
            {
                switch (audioSource.clip.name)
                {
                    case "�ٴٴ���BGM":
                        { seaToggle.isOn = false; }
                        break;
                    case "����Ѵ���BGM":
                        { freshToggle.isOn = false; }
                        break;
                    case "�ÿ��Ѵ���BGM":
                        { coolToggle.isOn = false; }
                        break;
                    case "�غ�����BGM":
                        { beachToggle.isOn = true; }
                        return;
                }
                audioSource.Pause();
                audioSource.clip = Resources.Load<AudioClip>("BGM/" + "�غ�����BGM");
                audioSource.Play();
            }
        }
    }
    public void SetFreshBGM(bool _check)
    {
        if (_check)
        {
            if (audioSource.clip.name != "�ٴٴ���BGM" && audioSource.clip.name != "����Ѵ���BGM" && audioSource.clip.name != "�ÿ��Ѵ���BGM" && audioSource.clip.name != "�غ�����BGM")
            {
                _check = false;
                return;
            }
            else
            {
                switch (audioSource.clip.name)
                {
                    case "�ٴٴ���BGM":
                        { seaToggle.isOn = false; }
                        break;
                    case "����Ѵ���BGM":
                        { freshToggle.isOn = true; }
                        return;
                    case "�ÿ��Ѵ���BGM":
                        { coolToggle.isOn = false; }
                        break;
                    case "�غ�����BGM":
                        { beachToggle.isOn = false; }
                        break;
                }
                audioSource.Pause();
                audioSource.clip = Resources.Load<AudioClip>("BGM/" + "����Ѵ���BGM");
                audioSource.Play();
            }
        }
    }
    public void SetCoolBGM(bool _check)
    {
        if (_check)
        {
            if (audioSource.clip.name != "�ٴٴ���BGM" && audioSource.clip.name != "����Ѵ���BGM" && audioSource.clip.name != "�ÿ��Ѵ���BGM" && audioSource.clip.name != "�غ�����BGM")
            {
                _check = false;
                return;
            }
            else
            {
                switch (audioSource.clip.name)
                {
                    case "�ٴٴ���BGM":
                        { seaToggle.isOn = false; }
                        break;
                    case "����Ѵ���BGM":
                        { freshToggle.isOn = false; }
                        break;
                    case "�ÿ��Ѵ���BGM":
                        { coolToggle.isOn = true; }
                        return;
                    case "�غ�����BGM":
                        { beachToggle.isOn = false; }
                        break;
                }
                audioSource.Pause();
                audioSource.clip = Resources.Load<AudioClip>("BGM/" + "�ÿ��Ѵ���BGM");
                audioSource.Play();
            }
        }
    }
}
