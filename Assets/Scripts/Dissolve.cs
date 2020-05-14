using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
    Material material;

    bool isDissolving = false;
    bool forcedRecovery = false;
    float fade = 1f;
    public float min = .3f;
    float max = 1f;

    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    void Update()
    {
        if (Input.GetButtonDown("Cloak"))
        {
            isDissolving = true;
        } else if (Input.GetButtonUp("Cloak") ) {
            isDissolving = false;
        }

        if (isDissolving && !forcedRecovery)
        {
            fade -= Time.deltaTime;

            if (fade <= min)
            {
                fade = min;
            }
        } else
        {
            fade += Time.deltaTime;

            if (fade >= max)
            {
                fade = max;
            }
        }

        material.SetFloat("_Fade", fade);
    }

    public void overusePasue()
    {
        Debug.Log("Overuse!!");
        forcedRecovery = true;
    }

    public void endForceRecovery()
    {
        if (forcedRecovery)
        {
            Debug.Log("End Force Recovery");
            forcedRecovery = false;
        }
    }


}
