using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScriptForBOOGI : MonoBehaviour
{
    private BoogiAction_SY boogiAction = null;
    public GameObject spawnPointGO = null;
    public float boogiDistance = 5.0f;

    void Awake()
    {
        if (!boogiAction) boogiAction = GameObject.Find("Boogi").GetComponent<BoogiAction_SY>();
        // if (!boogiAction) boogiAction = GameObject.FindWithTag("NPC").GetComponent<BoogiAction_SY>();

        spawnPointGO = GameObject.Instantiate(Resources.Load<GameObject>("Prefab/SpawnPointGO"),transform.position + new Vector3(0, 0, -boogiDistance),Quaternion.identity);
        spawnPointGO.transform.SetParent(transform);
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
