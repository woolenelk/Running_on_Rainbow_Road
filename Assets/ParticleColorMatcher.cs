using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleColorMatcher : MonoBehaviour
{
    [SerializeField]
    ColorHolder colorHolder;
    ParticleSystem.MainModule main;
    private void Awake()
    {
        main = GetComponent<ParticleSystem>().main;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        switch (colorHolder.color)
        {
            case PlatformColor.Red:
                main.startColor = Color.red;
                break;
            case PlatformColor.Green:
                main.startColor = Color.green;
                break;
            case PlatformColor.Blue:
                main.startColor = Color.blue;
                break;
            case PlatformColor.White:
                main.startColor = Color.white;
                break;
        }
    }
}
