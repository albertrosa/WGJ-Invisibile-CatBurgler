using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    
    public Text textBox;

    bool started = false;
    float remainingStart;
    public float maxTime = 10;
    public float restoreSpeed = 1.0f;
    public float usageRate = 1.0f;

    private void Start()
    {
        remainingStart = maxTime;
        if (textBox)
        {
            textBox.text = remainingStart.ToString();
        }
    }


    public void Update()
    {
        if (started)
        {
            Debug.Log(started.ToString());
            remainingStart = remainingStart - Time.deltaTime;
            textBox.text = Mathf.Round(remainingStart).ToString();
        }
        else if (remainingStart < maxTime)
        {
            remainingStart = remainingStart + (Time.deltaTime * restoreSpeed);
            textBox.text = Mathf.Round(remainingStart).ToString();
        }
    }

    public void startTimer()
    {
        started = true;
    }

    public void stopTimer()
    {
        started = false;
    }

}
