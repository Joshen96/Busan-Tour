using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class JS_Fish_game : MonoBehaviour
{

    public float timecount = 30f;
    public TMP_Text timetext;
    public TMP_Text scoretext;
    public GameObject startbutton;
    public bool _isgamestart = false;

    public int gamescore = 0;

    private void Update()
    {
        if(_isgamestart)
        {
            startbutton.SetActive(false);
            timecount -= Time.deltaTime;
        }
        if (timecount <= 0)
        {
            
            _isgamestart = false;
            timecount = 30;
            startbutton.SetActive(true);
        }
        
        timetext.text = timecount.ToString("F1");
        scoretext.text = gamescore.ToString();
    }

    public void GameStart()
    {
        _isgamestart =true;
        gamescore = 0;
    }

    public void getpoint()
    {
        gamescore++;
    }
}
