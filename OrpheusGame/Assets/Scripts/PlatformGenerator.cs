using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    public float maxDistance;
    public float distanceBetweenPlatforms;
    public GameObject player;
    public GameObject currPlatform;
    public GameObject currPlatform2;
    public GameObject startingPlatform;
    float y;
    // Start is called before the first frame update
    void Start()
    {
        y = currPlatform.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(currPlatform.transform.position.x < player.transform.position.x - maxDistance)
        {
            Debug.Log("here");
            float copyX = currPlatform2.transform.position.x;
            currPlatform.transform.position = new Vector3(copyX+distanceBetweenPlatforms,y,0);
        }
        if (currPlatform2.transform.position.x < player.transform.position.x - maxDistance)
        {
            Debug.Log("here");
            float copyX = currPlatform.transform.position.x;
            currPlatform2.transform.position = new Vector3(copyX + distanceBetweenPlatforms, y, 0);
        }
    }
}
