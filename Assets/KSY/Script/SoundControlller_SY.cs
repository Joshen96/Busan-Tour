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
            // 나머지 토글 끄기
            beachToggle.isOn = false;
            freshToggle.isOn = false;
            coolToggle.isOn = false;

            if (!audioSource.clip)      // 오디오 클립 null이면
            {
                audioSource.clip = Resources.Load<AudioClip>("BGM/" + "바다느낌BGM");
                audioSource.Play();
            }
            else                        // 오디오 클립 null 아니면
            {
                if (audioSource.clip.name != "바다느낌BGM" && audioSource.clip.name != "해변느낌BGM" && audioSource.clip.name != "산뜻한느낌BGM" && audioSource.clip.name != "시원한느낌BGM") return;
                // nusic콜라이더 영향을 받는 중이므로 return

                else if (audioSource.clip.name == "바다느낌BGM")
                {
                    if (audioSource.isPlaying) return;
                    else audioSource.Play();
                }

                else if (audioSource.clip.name != "바다느낌BGM")
                {
                    audioSource.Pause();
                    audioSource.clip = Resources.Load<AudioClip>("BGM/" + "바다느낌BGM");
                    audioSource.Play();
                }
            }
        }
    }

    public void SetBeachBGM(bool _check)
    {
        if (_check)
        {
            // 나머지 토글 끄기
            seaToggle.isOn = false;
            freshToggle.isOn = false;
            coolToggle.isOn = false;

            if (!audioSource.clip)      // 오디오 클립 null이면
            {
                audioSource.clip = Resources.Load<AudioClip>("BGM/" + "해변느낌BGM");
                audioSource.Play();
            }
            else                        // 오디오 클립 null 아니면
            {
                if (audioSource.clip.name != "바다느낌BGM" && audioSource.clip.name != "해변느낌BGM" && audioSource.clip.name != "산뜻한느낌BGM" && audioSource.clip.name != "시원한느낌BGM") return;
                // nusic콜라이더 영향을 받는 중이므로 return

                else if (audioSource.clip.name == "해변느낌BGM")
                {
                    if (audioSource.isPlaying) return;
                    else audioSource.Play();
                }

                else if (audioSource.clip.name != "해변느낌BGM")
                {
                    audioSource.Pause();
                    audioSource.clip = Resources.Load<AudioClip>("BGM/" + "해변느낌BGM");
                    audioSource.Play();
                }
            }
        }
    }
    public void SetFreshBGM(bool _check)
    {
        if (_check)
        {
            // 나머지 토글 끄기
            beachToggle.isOn = false;
            seaToggle.isOn = false;
            coolToggle.isOn = false;

            if (!audioSource.clip)      // 오디오 클립 null이면
            {
                audioSource.clip = Resources.Load<AudioClip>("BGM/" + "산뜻한느낌BGM");
                audioSource.Play();
            }
            else                        // 오디오 클립 null 아니면
            {
                if (audioSource.clip.name != "바다느낌BGM" && audioSource.clip.name != "해변느낌BGM" && audioSource.clip.name != "산뜻한느낌BGM" && audioSource.clip.name != "시원한느낌BGM") return;
                // nusic콜라이더 영향을 받는 중이므로 return

                else if (audioSource.clip.name == "산뜻한느낌BGM")
                {
                    if (audioSource.isPlaying) return;
                    else audioSource.Play();
                }

                else if (audioSource.clip.name != "산뜻한느낌BGM")
                {
                    audioSource.Pause();
                    audioSource.clip = Resources.Load<AudioClip>("BGM/" + "산뜻한느낌BGM");
                    audioSource.Play();
                }
            }
        }
    }
    public void SetCoolBGM(bool _check)
    {
        if (_check)
        {
            // 나머지 토글 끄기
            beachToggle.isOn = false;
            freshToggle.isOn = false;
            seaToggle.isOn = false;

            if (!audioSource.clip)      // 오디오 클립 null이면
            {
                audioSource.clip = Resources.Load<AudioClip>("BGM/" + "시원한느낌BGM");
                audioSource.Play();
            }
            else                        // 오디오 클립 null 아니면
            {
                if (audioSource.clip.name != "바다느낌BGM" && audioSource.clip.name != "해변느낌BGM" && audioSource.clip.name != "산뜻한느낌BGM" && audioSource.clip.name != "시원한느낌BGM") return;
                // nusic콜라이더 영향을 받는 중이므로 return

                else if (audioSource.clip.name == "시원한느낌BGM")
                {
                    if (audioSource.isPlaying) return;
                    else audioSource.Play();
                }

                else if (audioSource.clip.name != "시원한느낌BGM")
                {
                    audioSource.Pause();
                    audioSource.clip = Resources.Load<AudioClip>("BGM/" + "시원한느낌BGM");
                    audioSource.Play();
                }
            }
        }
    }
}
