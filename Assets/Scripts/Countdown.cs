using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Countdown : MonoBehaviour
{
    
    public Text textBox;

    bool started = false;
    float remainingStart;
    public float maxTime = 10;
    public float restoreSpeed = 1.0f;
    public float usageRate = 1.0f;

    [Header("Event")]
    [Space]
    public UnityEvent OnEndEvent;
    [Space]
    public UnityEvent OnRestartEvent;


    public void Awake()
    {
        if (OnEndEvent == null)
            OnEndEvent = new UnityEvent();
        if (OnRestartEvent == null)
            OnRestartEvent = new UnityEvent();
    }


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
        if (started && remainingStart != 0)
        {
            Debug.Log(started.ToString());
            remainingStart = remainingStart - (Time.deltaTime * usageRate);
            if (remainingStart <= 0)
            {
                remainingStart = 0;
                OnEndEvent.Invoke();
            }
            textBox.text = Mathf.Round(remainingStart).ToString();
        }

        if (!started && remainingStart != maxTime)
        {
            if(remainingStart >= maxTime)
            {
                remainingStart = maxTime;
                OnRestartEvent.Invoke();
            }

            remainingStart = remainingStart + (Time.deltaTime * restoreSpeed);
            textBox.text = Mathf.Round(remainingStart).ToString();

            if (remainingStart == maxTime)
            {
                OnRestartEvent.Invoke();
            }
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
