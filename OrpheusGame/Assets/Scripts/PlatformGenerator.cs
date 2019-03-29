using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject longPlatform;
    public GameObject mediumPlatform;
    public GameObject shortPlatform;
    public float moveSpeed = 0.1f;
    public float maxDistance;
    public float distanceBetweenPlatforms;
    public GameObject player;
    public GameObject currPlatform;
    public GameObject currPlatform2;
    public GameObject startingPlatform;
    GameObject gOToInstantiate;
    GameObject newPlatform;
    List<GameObject> gOToDestroy = new List<GameObject>();
    float y;
    // Start is called before the first frame update
    void Start()
    {
        newPlatform = Instantiate(longPlatform);
        y = currPlatform.transform.position.y;
        newPlatform.transform.position = new Vector3(player.transform.position.x + 5 + distanceBetweenPlatforms, y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(newPlatform.transform.position.x < player.transform.position.x)
        {
            int tier = Random.Range(1, 4);
            int size = Random.Range(1, 4);

            switch (tier)
            {
                case 1:
                    y = -2f;
                    break;
                case 2:
                    y = 0f;
                    break;
                case 3:
                    y = 2f;
                    break;
            }
            switch (size)
            {
                case 1:
                    gOToInstantiate = shortPlatform;
                    break;
                case 2:
                    gOToInstantiate = mediumPlatform;
                    break;
                case 3:
                    gOToInstantiate = longPlatform;
                    break;
            }
            gOToDestroy.Add(newPlatform);
            newPlatform = Instantiate(gOToInstantiate);
            newPlatform.transform.position = new Vector3(player.transform.position.x+ distanceBetweenPlatforms,y,0);
            if (gOToDestroy.Count > 4)
            {
                Debug.Log('l');

                Destroy(gOToDestroy[0]);
                gOToDestroy.RemoveAt(0);

            }
        }
    }
}
