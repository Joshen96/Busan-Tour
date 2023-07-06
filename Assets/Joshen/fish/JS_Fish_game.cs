using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class JS_Fish_game : MonoBehaviour
{

    public float timecount = 30f;
    public TMP_Text timetext;
    public TMP_Text scoretext;
    public bool _isgamestart = false;

    public int gamescore = 0;

    private void Update()
    {
        if(_isgamestart)
        {
            timecount -= Time.deltaTime;
        }
        if (timecount <= 0)
        {
            _isgamestart = false;
            timecount = 30;
            
        }
        timetext.text = timecount.ToString();
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
