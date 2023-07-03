using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Name_SY : MonoBehaviour
{

    private void Awake()
    {
        for (int i = 1; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
    }

    private void FadeOut()
    {
        StartCoroutine(FadeOut(transform.childCount-1, 1.5f));
    }

    IEnumerator FadeOut(int _childNum, float fadeOutTime)
    {
        yield return new WaitForSeconds(2.0f);

        transform.GetChild(_childNum).gameObject.SetActive(true);
        SpriteRenderer spriteRenderer = transform.GetChild(_childNum).gameObject.GetComponent<SpriteRenderer>();

        Color tempColor = spriteRenderer.color;
        while (tempColor.a > 0f)
        {
            tempColor.a -= Time.deltaTime / fadeOutTime;
            spriteRenderer.color = tempColor;
        }

        if (tempColor.a <= 0f)
        {
            tempColor.a = 0f;
            spriteRenderer.gameObject.SetActive(false);
        }

        if (_childNum > 0) StartCoroutine(FadeOut(_childNum-1, fadeOutTime));
    }
}
