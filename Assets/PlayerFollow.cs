using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, playerTransform.position.x, Time.deltaTime),
                                         Mathf.Lerp(transform.position.y, playerTransform.position.y, Time.deltaTime),
                                         Mathf.Lerp(transform.position.z, playerTransform.position.z, Time.deltaTime));
    }
}
