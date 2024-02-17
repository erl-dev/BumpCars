using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreScriptP1 : MonoBehaviour
{
    public static ScoreScriptP1 instance;

    public TMP_Text scoreText;
    public static int scoreP1 = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = scoreP1.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddPointCar1()
    {
        scoreP1 += 100;
        scoreText.text = scoreP1.ToString();
    }

    public void AddPointCar23()
    {
        scoreP1 += 80;
        scoreText.text = scoreP1.ToString();
    }

    public void AddPointCar4()
    {
        scoreP1 += 30;
        scoreText.text = scoreP1.ToString();
    }

    public void AddPointCar5()
    {
        scoreP1 += 10;
        scoreText.text = scoreP1.ToString();
    }

}
