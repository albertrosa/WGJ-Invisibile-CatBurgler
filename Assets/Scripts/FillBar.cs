using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    void setColor()
    {
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    public void setMaxFill(float amount)
    {
        slider.maxValue = amount;
        slider.value = amount;

        setColor();
    }

    public void setFill(float fillAmount)
    {
        slider.value = fillAmount;
        setColor();
    }

    public void setMaxFill(int amount)
    {
        slider.maxValue = amount;
        slider.value = amount;
        setColor();
    }

    public void setFill(int fillAmount)
    {
        slider.value = fillAmount;
        setColor();
    }
}
