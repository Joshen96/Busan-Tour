using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundControlller_SY : MonoBehaviour
{
    public AudioSource audioSource = null;
    [SerializeField] private Slider slider = null;
    private float preSoundVolume = 0;

    #region Public Variables
    [Header(" BGM Toggle -")]
    public Toggle seaToggle = null;
    public Toggle beachToggle = null;
    public Toggle freshToggle = null;
    public Toggle coolToggle = null;

    [Header(" Drone Toggle -")]
    public Toggle electronicToggle = null;
    public Toggle broadcastToggle = null;
    public Toggle dandyToggle = null;

    [Header(" Party Toggle -")]
    public Toggle gayageumToggle = null;
    public Toggle TrotToggle = null;
    public Toggle jazzToggle = null;

    #endregion


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

    // BGM
    #region Public Variables

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
    #endregion


    // Drone
    #region Public Variables
    public void SetElectronicBGM(bool _check)
    {
        if (_check)
        {
            // 나머지 토글 끄기
            broadcastToggle.isOn = false;
            dandyToggle.isOn = false;

            if (!audioSource.clip)      // 오디오 클립 null이면
            {
                audioSource.clip = Resources.Load<AudioClip>("BGM/" + "일렉트로닉드론BGM");
                audioSource.Play();
            }
            else                        // 오디오 클립 null 아니면
            {
                if (audioSource.clip.name != "일렉트로닉드론BGM" && audioSource.clip.name != "멋쟁이드론BGM" && audioSource.clip.name != "브로드캐스트드론BGM")
                {
                    audioSource.Pause();
                    audioSource.clip = Resources.Load<AudioClip>("BGM/" + "일렉트로닉드론BGM");
                    audioSource.Play();
                }

                else if (audioSource.clip.name == "일렉트로닉드론BGM")
                {
                    if (audioSource.isPlaying) return;
                    else audioSource.Play();
                }

                else if (audioSource.clip.name != "일렉트로닉드론BGM")
                {
                    audioSource.Pause();
                    audioSource.clip = Resources.Load<AudioClip>("BGM/" + "일렉트로닉드론BGM");
                    audioSource.Play();
                }
            }
        }
    }
    public void SetBroadcastBGM(bool _check)
    {
        if (_check)
        {
            // 나머지 토글 끄기
            electronicToggle.isOn = false;
            dandyToggle.isOn = false;

            if (!audioSource.clip)      // 오디오 클립 null이면
            {
                audioSource.clip = Resources.Load<AudioClip>("BGM/" + "브로드캐스트드론BGM");
                audioSource.Play();
            }
            else                        // 오디오 클립 null 아니면
            {
                if (audioSource.clip.name != "일렉트로닉드론BGM" && audioSource.clip.name != "멋쟁이드론BGM" && audioSource.clip.name != "브로드캐스트드론BGM")
                {
                    audioSource.Pause();
                    audioSource.clip = Resources.Load<AudioClip>("BGM/" + "브로드캐스트드론BGM");
                    audioSource.Play();
                }

                else if (audioSource.clip.name == "브로드캐스트드론BGM")
                {
                    if (audioSource.isPlaying) return;
                    else audioSource.Play();
                }

                else if (audioSource.clip.name != "브로드캐스트드론BGM")
                {
                    audioSource.Pause();
                    audioSource.clip = Resources.Load<AudioClip>("BGM/" + "브로드캐스트드론BGM");
                    audioSource.Play();
                }
            }
        }
    }
    public void SetDandyBGM(bool _check)
    {
        if (_check)
        {
            // 나머지 토글 끄기
            electronicToggle.isOn = false;
            broadcastToggle.isOn = false;

            if (!audioSource.clip)      // 오디오 클립 null이면
            {
                audioSource.clip = Resources.Load<AudioClip>("BGM/" + "멋쟁이드론BGM");
                audioSource.Play();
            }
            else                        // 오디오 클립 null 아니면
            {
                if (audioSource.clip.name != "일렉트로닉드론BGM" && audioSource.clip.name != "멋쟁이드론BGM" && audioSource.clip.name != "브로드캐스트드론BGM")
                {
                    audioSource.Pause();
                    audioSource.clip = Resources.Load<AudioClip>("BGM/" + "멋쟁이드론BGM");
                    audioSource.Play();
                }

                else if (audioSource.clip.name == "멋쟁이드론BGM")
                {
                    if (audioSource.isPlaying) return;
                    else audioSource.Play();
                }

                else if (audioSource.clip.name != "멋쟁이드론BGM")
                {
                    audioSource.Pause();
                    audioSource.clip = Resources.Load<AudioClip>("BGM/" + "멋쟁이드론BGM");
                    audioSource.Play();
                }
            }
        }
    }
    #endregion


    // Party
    #region Public Variables

    public void SetGayageumBGM(bool _check)
    {
        if (_check)
        {
            // 나머지 토글 끄기
            TrotToggle.isOn = false;
            jazzToggle.isOn = false;

            if (!audioSource.clip)      // 오디오 클립 null이면
            {
                audioSource.clip = Resources.Load<AudioClip>("BGM/" + "가야금파티BGM");
                audioSource.Play();
            }
            else                        // 오디오 클립 null 아니면
            {
                if (audioSource.clip.name != "가야금파티BGM" && audioSource.clip.name != "재즈파티BGM" && audioSource.clip.name != "트로트파티BGM")
                {
                    audioSource.Pause();
                    audioSource.clip = Resources.Load<AudioClip>("BGM/" + "가야금파티BGM");
                    audioSource.Play();
                }

                else if (audioSource.clip.name == "가야금파티BGM")
                {
                    if (audioSource.isPlaying) return;
                    else audioSource.Play();
                }

                else if (audioSource.clip.name != "가야금파티BGM")
                {
                    audioSource.Pause();
                    audioSource.clip = Resources.Load<AudioClip>("BGM/" + "가야금파티BGM");
                    audioSource.Play();
                }
            }
        }
    }

    public void SetTrotBGM(bool _check)
    {
        if (_check)
        {
            // 나머지 토글 끄기
            gayageumToggle.isOn = false;
            jazzToggle.isOn = false;

            if (!audioSource.clip)      // 오디오 클립 null이면
            {
                audioSource.clip = Resources.Load<AudioClip>("BGM/" + "트로트파티BGM");
                audioSource.Play();
            }
            else                        // 오디오 클립 null 아니면
            {
                if (audioSource.clip.name != "가야금파티BGM" && audioSource.clip.name != "재즈파티BGM" && audioSource.clip.name != "트로트파티BGM")
                {
                    audioSource.Pause();
                    audioSource.clip = Resources.Load<AudioClip>("BGM/" + "트로트파티BGM");
                    audioSource.Play();
                }

                else if (audioSource.clip.name == "트로트파티BGM")
                {
                    if (audioSource.isPlaying) return;
                    else audioSource.Play();
                }

                else if (audioSource.clip.name != "트로트파티BGM")
                {
                    audioSource.Pause();
                    audioSource.clip = Resources.Load<AudioClip>("BGM/" + "트로트파티BGM");
                    audioSource.Play();
                }
            }
        }
    }

    public void SetJazzBGM(bool _check)
    {
        if (_check)
        {
            // 나머지 토글 끄기
            gayageumToggle.isOn = false;
            TrotToggle.isOn = false;

            if (!audioSource.clip)      // 오디오 클립 null이면
            {
                audioSource.clip = Resources.Load<AudioClip>("BGM/" + "재즈파티BGM");
                audioSource.Play();
            }
            else                        // 오디오 클립 null 아니면
            {
                if (audioSource.clip.name != "가야금파티BGM" && audioSource.clip.name != "재즈파티BGM" && audioSource.clip.name != "트로트파티BGM")
                {
                    audioSource.Pause();
                    audioSource.clip = Resources.Load<AudioClip>("BGM/" + "재즈파티BGM");
                    audioSource.Play();
                }

                else if (audioSource.clip.name == "재즈파티BGM")
                {
                    if (audioSource.isPlaying) return;
                    else audioSource.Play();
                }

                else if (audioSource.clip.name != "재즈파티BGM")
                {
                    audioSource.Pause();
                    audioSource.clip = Resources.Load<AudioClip>("BGM/" + "재즈파티BGM");
                    audioSource.Play();
                }
            }
        }
    }
    #endregion


}
