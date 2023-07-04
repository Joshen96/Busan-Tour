using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Name_SY : MonoBehaviour
{
    [SerializeField] private SpriteRenderer nameRenderer = null;

    public void FadeOut()               // 언어버튼 눌리면 시행되도록(+), 위치는 부기처럼 플레이어 앞에?
    {
        StartCoroutine(FadeOut(0));
    }

    IEnumerator FadeOut(int index)
    {
        GameObject _nameGO = transform.GetChild(index).gameObject;
        _nameGO.SetActive(true);

        nameRenderer = transform.GetChild(index).GetComponent<SpriteRenderer>();

        Color tempColor = nameRenderer.color;
        yield return new WaitForSeconds(2.0f);
        while (tempColor.a > 0f)
        {
            tempColor.a -= Time.deltaTime / 2f /*FadeoutTime*/;
            nameRenderer.color = tempColor;

            if (tempColor.a <= 0f)
            { 
                tempColor.a = 0f;
            }
            yield return null;              // 필수
        }
        nameRenderer.color = tempColor;
        yield return new WaitForSeconds(2.0f);

        index++;

       if (index < transform.childCount) StartCoroutine(FadeOut(index));
    }
}
