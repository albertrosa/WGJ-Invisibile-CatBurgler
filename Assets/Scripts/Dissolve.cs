using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
    Material material;

    bool isDissolving = false;
    float fade = 1f;

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

        if (isDissolving)
        {
            fade -= Time.deltaTime;

            if (fade <= 0)
            {
                fade = 0;
            }
        } else
        {
            fade += Time.deltaTime;

            if (fade >= 1)
            {
                fade = 1;
            }
        }

        material.SetFloat("_Fade", fade);

    }
}
