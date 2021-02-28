using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    Animator animator;
    [SerializeField]
    GameObject colorBlob;
    [SerializeField]
    Transform spawnPoint;
    [SerializeField]
    float timer;
    private void Awake()
    {
        timer = 3;
        animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timer >= 0)
        {
            timer -= Time.deltaTime;
            if (timer <=0)
            {
                StartCoroutine(Sploosh());
            }
        }
        
    }

    IEnumerator Sploosh()
    {
        animator.SetBool("Spit", true);
        yield return new WaitForSeconds(2.0f);
        animator.SetBool("Spit", false);
        Instantiate(colorBlob, spawnPoint.position, Quaternion.identity);
        timer = Random.Range(5.0f, 10.0f);
    }
}
