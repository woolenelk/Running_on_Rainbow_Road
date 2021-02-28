using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBlob : MonoBehaviour
{

    float timer = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
            Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DeathPlane"))
            Destroy(gameObject);
        if (other.gameObject.CompareTag("Ground"))
        {
            other.gameObject.GetComponent<ColorHolder>().color = GetComponent<ColorHolder>().color;
            Destroy(gameObject);
        }
    }
}
