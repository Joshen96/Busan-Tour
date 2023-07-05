using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicCollider_SY : MonoBehaviour
{
    [SerializeField] private float BGM_volume = 1.0f;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            while (other.GetComponent<AudioSource>().volume > 0)
            {
                other.GetComponent<AudioSource>().volume -= Time.deltaTime / 1.5f; // 1.5�ʵ��� ������ 0���� �����.

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
                other.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>("Sound/" + gameObject.name);
                // ������� ������ �ɷ� ����Ǳ� ��������(-)
                other.GetComponent<AudioSource>().volume = 1;
                other.GetComponent<AudioSource>().Play();
            }
        }
    }
}