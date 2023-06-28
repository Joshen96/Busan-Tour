using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScriptForBOOGI : MonoBehaviour
{
    // �÷��̾�� spawnPoint ������ּ���~~~
    private BoogiAction_SY boogiAction = null;

    void Awake()
    {
        if (!boogiAction) boogiAction = GameObject.Find("Boogi").GetComponent<BoogiAction_SY>();
    }
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        boogiAction.PlayerOnTriggerEnter(other);
    }

    private void OnTriggerStay(Collider other)
    {
        boogiAction.PlayerOnTriggerStay(other);
    }

    private void OnTriggerExit(Collider other)
    {
        boogiAction.PlayerOnTriggerExit(other);
    }

    private IEnumerator OneSecond()
    {
        yield return new WaitForSeconds(1.0f);
    }
}
