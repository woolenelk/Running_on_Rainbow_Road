using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    [SerializeField]
    List<GameObject> PlatformPrefabs;
    [SerializeField]
    List<GameObject> PlatformsInPlay;
    [SerializeField]
    float timer = 0;
    [SerializeField]
    int MinimumPlatformActive;
    [SerializeField]
    float spacing = 15;
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        while (PlatformsInPlay.Count < MinimumPlatformActive)
        {
            GameObject tempPlat = Instantiate(PlatformPrefabs[0], new Vector3(0, 0, PlatformsInPlay[PlatformsInPlay.Count - 1].transform.position.z + spacing), Quaternion.identity);
            ColorHolder tempPlatcolor = tempPlat.GetComponentInChildren<ColorHolder>();
            tempPlat.GetComponent<RoadMovement>().speed = speed;
            PlatformsInPlay.Add(tempPlat);
            tempPlatcolor.color = PlatformColor.White;
        }
        InvokeRepeating("IncreaseSpeed", 5, 5);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        while (PlatformsInPlay.Count < MinimumPlatformActive)
        {
            GameObject tempPlat = Instantiate(PlatformPrefabs[Random.Range(0, PlatformPrefabs.Count)], new Vector3(0, 0, PlatformsInPlay[PlatformsInPlay.Count - 1].transform.position.z + spacing), Quaternion.identity);
            //ColorHolder tempPlatcolor = tempPlat.GetComponentInChildren<ColorHolder>();
            tempPlat.GetComponent<RoadMovement>().speed = speed;
            PlatformsInPlay.Add(tempPlat);
            tempPlat.transform.localScale = new Vector3(1, 1, speed / 10.0f);
        }
    }
    public void IncreaseSpeed()
    {
        speed += 0.5f;
        spacing += 1.0f;
        foreach (GameObject platform in PlatformsInPlay)
        {
            platform.GetComponent<RoadMovement>().speed = speed ;
        }
        Debug.Log(speed);
    }
    public void RemovePlatform(GameObject platform)
    {
        if (PlatformsInPlay.Contains(platform))
        {
            PlatformsInPlay.Remove(platform);
            Destroy(platform);
        }
    }
}
