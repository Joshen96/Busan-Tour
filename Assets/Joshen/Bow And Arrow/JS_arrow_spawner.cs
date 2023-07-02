using System.Collections;

using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class JS_arrow_spawner : MonoBehaviour
{
    public GameObject arrow;
    public GameObject notch;

    private XRGrabInteractable _bow;
    private bool _arrowNotched = false;
    private GameObject _currentArrow = null;

    private void Start()
    {
        _bow = GetComponent<XRGrabInteractable>();
        JS_pull_arrow.PullActionReleased += NotchEmpty;
    }
    private void OnDestroy()
    {
        JS_pull_arrow.PullActionReleased -= NotchEmpty;
    }

    private void Update()
    {
        if(_bow.isSelected&&_arrowNotched==false)
        {
            _arrowNotched = true;
            StartCoroutine("DelayedSpawn");
        }
        if(!_bow.isSelected&&_currentArrow!=null)
        {
            Destroy(_currentArrow);
            NotchEmpty(1f);
        }
    }

    private void NotchEmpty(float value)
    {
        _arrowNotched = false;
        _currentArrow = null;
    }
    IEnumerator DelayedSpawn()
    {
        yield return new WaitForSeconds(1f);
        _currentArrow = Instantiate(arrow, notch.transform);
    }
}
