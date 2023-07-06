using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundControlller_SY : MonoBehaviour
{
    public AudioSource audioSource = null;
    [SerializeField] private Slider slider = null;
    private float preSoundVolume = 0;

    public Toggle seaToggle = null;
    public Toggle beachToggle = null;
    public Toggle freshToggle = null;
    public Toggle coolToggle = null;

    private void Awake()
    {
        if (!audioSource) audioSource = GameObject.FindWithTag("Player").GetComponent<AudioSource>();
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
            // ������ ��� ����
            beachToggle.isOn = false;
            freshToggle.isOn = false;
            coolToggle.isOn = false;

            if (!audioSource.clip)      // ����� Ŭ�� null�̸�
            {
                audioSource.clip = Resources.Load<AudioClip>("BGM/" + "�ٴٴ���BGM");
                audioSource.Play();
            }
            else                        // ����� Ŭ�� null �ƴϸ�
            {
                if (audioSource.clip.name != "�ٴٴ���BGM" && audioSource.clip.name != "�غ�����BGM" && audioSource.clip.name != "����Ѵ���BGM" && audioSource.clip.name != "�ÿ��Ѵ���BGM") return;
                // nusic�ݶ��̴� ������ �޴� ���̹Ƿ� return

                else if (audioSource.clip.name == "�ٴٴ���BGM")
                {
                    if (audioSource.isPlaying) return;
                    else audioSource.Play();
                }

                else if (audioSource.clip.name != "�ٴٴ���BGM")
                {
                    audioSource.Pause();
                    audioSource.clip = Resources.Load<AudioClip>("BGM/" + "�ٴٴ���BGM");
                    audioSource.Play();
                }
            }
        }
    }

    public void SetBeachBGM(bool _check)
    {
        if (_check)
        {
            // ������ ��� ����
            seaToggle.isOn = false;
            freshToggle.isOn = false;
            coolToggle.isOn = false;

            if (!audioSource.clip)      // ����� Ŭ�� null�̸�
            {
                audioSource.clip = Resources.Load<AudioClip>("BGM/" + "�غ�����BGM");
                audioSource.Play();
            }
            else                        // ����� Ŭ�� null �ƴϸ�
            {
                if (audioSource.clip.name != "�ٴٴ���BGM" && audioSource.clip.name != "�غ�����BGM" && audioSource.clip.name != "����Ѵ���BGM" && audioSource.clip.name != "�ÿ��Ѵ���BGM") return;
                // nusic�ݶ��̴� ������ �޴� ���̹Ƿ� return

                else if (audioSource.clip.name == "�غ�����BGM")
                {
                    if (audioSource.isPlaying) return;
                    else audioSource.Play();
                }

                else if (audioSource.clip.name != "�غ�����BGM")
                {
                    audioSource.Pause();
                    audioSource.clip = Resources.Load<AudioClip>("BGM/" + "�غ�����BGM");
                    audioSource.Play();
                }
            }
        }
    }
    public void SetFreshBGM(bool _check)
    {
        if (_check)
        {
            // ������ ��� ����
            beachToggle.isOn = false;
            seaToggle.isOn = false;
            coolToggle.isOn = false;

            if (!audioSource.clip)      // ����� Ŭ�� null�̸�
            {
                audioSource.clip = Resources.Load<AudioClip>("BGM/" + "����Ѵ���BGM");
                audioSource.Play();
            }
            else                        // ����� Ŭ�� null �ƴϸ�
            {
                if (audioSource.clip.name != "�ٴٴ���BGM" && audioSource.clip.name != "�غ�����BGM" && audioSource.clip.name != "����Ѵ���BGM" && audioSource.clip.name != "�ÿ��Ѵ���BGM") return;
                // nusic�ݶ��̴� ������ �޴� ���̹Ƿ� return

                else if (audioSource.clip.name == "����Ѵ���BGM")
                {
                    if (audioSource.isPlaying) return;
                    else audioSource.Play();
                }

                else if (audioSource.clip.name != "����Ѵ���BGM")
                {
                    audioSource.Pause();
                    audioSource.clip = Resources.Load<AudioClip>("BGM/" + "����Ѵ���BGM");
                    audioSource.Play();
                }
            }
        }
    }
    public void SetCoolBGM(bool _check)
    {
        if (_check)
        {
            // ������ ��� ����
            beachToggle.isOn = false;
            freshToggle.isOn = false;
            seaToggle.isOn = false;

            if (!audioSource.clip)      // ����� Ŭ�� null�̸�
            {
                audioSource.clip = Resources.Load<AudioClip>("BGM/" + "�ÿ��Ѵ���BGM");
                audioSource.Play();
            }
            else                        // ����� Ŭ�� null �ƴϸ�
            {
                if (audioSource.clip.name != "�ٴٴ���BGM" && audioSource.clip.name != "�غ�����BGM" && audioSource.clip.name != "����Ѵ���BGM" && audioSource.clip.name != "�ÿ��Ѵ���BGM") return;
                // nusic�ݶ��̴� ������ �޴� ���̹Ƿ� return

                else if (audioSource.clip.name == "�ÿ��Ѵ���BGM")
                {
                    if (audioSource.isPlaying) return;
                    else audioSource.Play();
                }

                else if (audioSource.clip.name != "�ÿ��Ѵ���BGM")
                {
                    audioSource.Pause();
                    audioSource.clip = Resources.Load<AudioClip>("BGM/" + "�ÿ��Ѵ���BGM");
                    audioSource.Play();
                }
            }
        }
    }
}
