using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;

public class RefreshBarP1 : MonoBehaviour
{
    public GameObject bar;
    public int time;

    void Start()
    {
        AnimateBar();     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimateBar(){
        LeanTween.scaleX(bar, 1, time);
    }
}
