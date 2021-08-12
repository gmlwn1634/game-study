using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager I;
    public float effectVolum;

    private void Awake()
    {
        I = this;

        if (effectVolum > 1.0f)
        {
            effectVolum = 1.0f;
        }
        else if (effectVolum < 0)
        {
            effectVolum = 0.0f;
        }
    }

}
