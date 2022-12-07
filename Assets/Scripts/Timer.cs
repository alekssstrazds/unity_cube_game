using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    private float timerCount;
    public Text timerText;
    void Start()
    {
        timerCount = 0;
        timerText.text="Laiks: "+ timerText.ToString();
    }
    void Update()
    {
        timerCount += Time.deltaTime;
    }
}
