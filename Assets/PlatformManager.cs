using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    //[SerializeField]
    //List<GameObject> PlatformPrefabs;
    //[SerializeField]
    //List<GameObject> PlatformsInPlay;
    [SerializeField]
    float timer = 0;
    [SerializeField]
    int MinimumPlatformActive;
    [SerializeField]
    float spacing = 15;

    // Start is called before the first frame update
    void Start()
    {
        //PlatformsInPlay.Add(Instantiate(PlatformPrefabs[0], new Vector3(0, 0, 0), Quaternion.identity));
        //while (PlatformsInPlay.Count < MinimumPlatformActive)
        //{
        //    PlatformsInPlay.Add(Instantiate(PlatformPrefabs[0], new Vector3(0, 0, PlatformsInPlay[PlatformsInPlay.Count - 1].transform.position.z + spacing), Quaternion.identity));
        //}
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //while (PlatformsInPlay.Count < MinimumPlatformActive)
        //{
            
        //    GameObject tempPlat = Instantiate(PlatformPrefabs[0], new Vector3(0, 0, PlatformsInPlay[PlatformsInPlay.Count - 1].transform.position.z + spacing), Quaternion.identity);
        //    ColorHolder tempPlatcolor = tempPlat.GetComponentInChildren<ColorHolder>();
        //    if ((int)timer % 60 == 0)
        //    {
        //        tempPlat.GetComponent<RoadMovement>().IncreaseSpeed();
        //    }
        //    if (tempPlatcolor != null)
        //    {
        //        tempPlatcolor.color = (PlatformColor) Random.Range(0, 3);
        //    }
        //    PlatformsInPlay.Add(tempPlat);

        //}
    }

    public void RemovePlatform(GameObject platform)
    {
        //if (PlatformsInPlay.Contains(platform))
        //{
        //    PlatformsInPlay.Remove(platform);
        //    Destroy(platform);
        //}
    }
}
