using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoogiAction_SY : MonoBehaviour
{
    [SerializeField] private SpeechBubbleText_SY speechText = null;
    [SerializeField] private GameObject languageSelectButton = null;
    [SerializeField] private GameObject nextButton = null;
    public GameObject SpeechBubble = null;
    [SerializeField] private GameObject player = null;
    [SerializeField] private GameObject HelloParticle = null;
    [SerializeField] private GameObject ByeParticle = null;
    [SerializeField] private GameObject spawnPosint = null;
    
    public string language = "";
    private bool isPickLanguage = false;
    public int textIndex = 0;
    public bool isClickNextButton = false;

    

    private void Awake()
    {
        if (!spawnPosint) Debug.LogError("spawnPosint넣으세요오오오오~!!!");

        StartCoroutine(FirstToStart());
    }


    private void Update()
    {
        LookPlayer();

        if (!isPickLanguage && (language == "KOR" || language == "ENG"))
        { 
            if (languageSelectButton.activeSelf) languageSelectButton.SetActive(false);
            if (speechText.gameObject.GetComponent<TextMeshProUGUI>().text == "언어를 선택하세요.\n(Choose a Language)")
            {
                if (SpeechBubble.activeSelf) SpeechBubble.SetActive(false);
                if (transform.GetChild(0).gameObject.activeSelf) transform.GetChild(0).gameObject.SetActive(false);// 애니(-)
                isPickLanguage = true;
            }
        }
    }

    public void PlayerOnTriggerEnter(Collider other)
    {
        if (language != "KOR" && language != "ENG") return;

        if (other.gameObject.tag == "TouristAttraction")
        {
            StartCoroutine(ParticleActivation(other));
        }
    }

    public void PlayerOnTriggerStay(Collider other)
    {
        if (language != "KOR" && language != "ENG") return;

        if (other.gameObject.tag == "TouristAttraction")       // 관광명소 태그 사용(-)
        {
            if (!isClickNextButton && textIndex == 0)
            {
                if (!SpeechBubble.activeSelf) SpeechBubble.SetActive(true);
                speechText.PlayTyping(textIndex);
                speechText.PlayAnim(textIndex);
                textIndex++;
            }

            if (isClickNextButton)
            {
                isClickNextButton = false;
                speechText.PlayTyping(textIndex);
                speechText.PlayAnim(textIndex);
                textIndex++;
            }
        }
    }

    public void PlayerOnTriggerExit(Collider other)
    {
        if (language != "KOR" && language != "ENG") return;

        if (other.gameObject.tag == "TouristAttraction")
        {
            StartCoroutine(ByeParticlePlay());
        }
    }

    private void LookPlayer()
    {
        Vector3 dir = transform.position - player.transform.position;
        dir.y = 0;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * 3f);
    }

    private IEnumerator ParticleActivation(Collider other)
    {
        if (HelloParticle.activeSelf) HelloParticle.SetActive(false);
        HelloParticle.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        if (!transform.GetChild(0).gameObject.activeSelf) transform.GetChild(0).gameObject.SetActive(true);
        SetBoogiPosition();
        if (!SpeechBubble.activeSelf) SpeechBubble.SetActive(true);
        speechText.gameObject.GetComponent<TextMeshProUGUI>().text = "";
        if (!nextButton.activeSelf) nextButton.SetActive(true);
        if (textIndex != 0) textIndex = 0;
        speechText.SetNpcTalkAni(language, other.gameObject.name);
    }

    private IEnumerator FirstToStart()
    {
        SetBoogiPosition();
        ByeParticle.SetActive(false);
        transform.GetChild(0).gameObject.SetActive(false);
        if (HelloParticle == null) HelloParticle = GameObject.Find("BoogiPaticle");
        if (ByeParticle == null) ByeParticle = GameObject.Find("ByeParticle");
        if (!HelloParticle.activeSelf) HelloParticle.SetActive(true);
        if (!player) player = GameObject.FindWithTag("Player");
        if (SpeechBubble.activeSelf) SpeechBubble.SetActive(false);

        yield return new WaitForSeconds(0.3f);

        transform.GetChild(0).gameObject.SetActive(true);
        speechText.gameObject.GetComponent<TextMeshProUGUI>().text = "언어를 선택하세요.\n(Choose a Language)";
        if (nextButton.activeSelf) nextButton.SetActive(false);
        if (!SpeechBubble.activeSelf) SpeechBubble.SetActive(true);
    }

    private IEnumerator ByeParticlePlay()
    {
        if (ByeParticle.activeSelf) ByeParticle.SetActive(false);
        if (SpeechBubble.activeSelf) SpeechBubble.SetActive(false);
        if (textIndex != 0) textIndex = 0;

        yield return new WaitForSeconds(2.0f);

        transform.GetChild(0).gameObject.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        ByeParticle.SetActive(true);
    }

    private void SetBoogiPosition()
    {
        transform.position = spawnPosint.transform.position;
    }
}
