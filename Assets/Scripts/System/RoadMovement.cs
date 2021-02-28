using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMovement : MonoBehaviour
{
    PlatformManager platformManager;
    [SerializeField]
    public float speed;

    private void Awake()
    {
        platformManager = GameObject.FindGameObjectWithTag("PlatformManager").GetComponent<PlatformManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movementDir = new Vector3 (0, 0, -1) * (speed * Time.deltaTime);
        transform.position += movementDir;
        Checkbounds();
    }

    void Checkbounds()
    {
        if (transform.position.z < -15 * transform.localScale.z)
        {
            platformManager.RemovePlatform(gameObject);
        }
    } 
}
