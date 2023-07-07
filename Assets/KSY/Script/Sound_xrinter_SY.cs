using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_xrinter_SY : MonoBehaviour
{
    public GameObject soundUI;

    public void openUI()
    {
        soundUI.SetActive(true);
    }
    public void closeUI()
    {
        soundUI.SetActive(false);
    }
}
