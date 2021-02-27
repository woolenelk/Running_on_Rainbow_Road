using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public enum PlatformColor : int
{
    Red,
    Blue, 
    Green,
    White,
}
public class ColorHolder : MonoBehaviour
{
    [SerializeField]
    public PlatformColor color;
    Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        switch (color)
        {
            case PlatformColor.Red:
                renderer.material.color = Color.red;
                break;
            case PlatformColor.Green:
                renderer.material.color = Color.green;
                break;
            case PlatformColor.Blue:
                renderer.material.color = Color.blue;
                break;
            case PlatformColor.White:
                renderer.material.color = Color.white;
                break;
        }
    }

    public void OnAddBlue (InputValue value)
    {
        color = PlatformColor.Blue;
        Debug.Log("add blue");
    }
    public void OnAddRed(InputValue value)
    {
        color = PlatformColor.Red ;
        Debug.Log("add Red");
    }
    public void OnAddGreen(InputValue value)
    {
        color = PlatformColor.Green;
        Debug.Log("add Green");
    }
}
