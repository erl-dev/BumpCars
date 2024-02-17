using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScriptP2 : MonoBehaviour
{
    public static ScoreScriptP2 instance;

    public TMP_Text scoreText;
    public static int scoreP2 = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = scoreP2.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddPointCar1()
    {
        scoreP2 += 100;
        scoreText.text = scoreP2.ToString();
    }

    public void AddPointCar23()
    {
       scoreP2 += 80;
        scoreText.text = scoreP2.ToString();
    }

    public void AddPointCar4()
    {
        scoreP2 += 30;
        scoreText.text = scoreP2.ToString();
    }

    public void AddPointCar5()
    {
        scoreP2 += 10;
        scoreText.text = scoreP2.ToString();
    }

}
