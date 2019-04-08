﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject longPlatform;
    public GameObject mediumPlatform;
    public GameObject shortPlatform;
    public float maxDistance;
    public float distanceBetweenPlatforms;
    public GameObject player;
    public GameObject currPlatform;
    public GameObject currPlatform2;
    public GameObject startingPlatform;
    GameObject gOToInstantiate;
    GameObject newPlatform;
    GameObject newPlatform2;
    public GameObject item;
    List<GameObject> gOToDestroy = new List<GameObject>();
    List<GameObject> gOToDestroy2 = new List<GameObject>();
    GameObject secondLayerPlatform;

    float y;
    float secondY;
    // Start is called before the first frame update
    void Start()
    {
        newPlatform = Instantiate(longPlatform);
        y = currPlatform.transform.position.y;
        newPlatform.transform.position = new Vector3(player.transform.position.x + 5 + distanceBetweenPlatforms, y, 0);

        secondLayerPlatform = Instantiate(longPlatform);
        secondY = newPlatform.transform.position.y - 3;
        newPlatform.transform.position = new Vector3(player.transform.position.x + 5 + distanceBetweenPlatforms, secondY, 0);
    }
    // Update is called once per frame
    void Update()
    {
        if (newPlatform.transform.position.x < player.transform.position.x)
        {
            int tier = Random.Range(1, 4);
            int size = Random.Range(1, 4);
            int itemChance = Random.Range(1, 10);

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

            newPlatform = Instantiate(gOToInstantiate);
            newPlatform.transform.position = new Vector3(player.transform.position.x + distanceBetweenPlatforms, y, 0);
            gOToDestroy.Add(newPlatform);
            if (itemChance > 7)
            {
                //GameObject newItem = Instantiate(item);
                //newItem.transform.position = newPlatform.transform.position + new Vector3(1, 3, 0);
            }
            if (gOToDestroy.Count > 4)
            {

                Destroy(gOToDestroy[0]);
                gOToDestroy.RemoveAt(0);

            }

            if (secondLayerPlatform.transform.position.x < player.transform.position.x)
            {
                int secondLayertier = Random.Range(1, 4);
                int secondLayersize = Random.Range(1, 4);
                int secondLayeritemChance = Random.Range(1, 10);

                switch (secondLayertier)
                {
                    case 1:
                        secondY = -2f - Random.Range(4,10);
                        break;
                    case 2:
                        secondY = 0f -Random.Range(4, 10);
                        break;
                    case 3:
                        secondY = 2f -Random.Range(4, 10);
                        break;
                }
                switch (secondLayersize)
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

                newPlatform2 = Instantiate(gOToInstantiate);
                newPlatform2.transform.position = 
                    new Vector3(player.transform.position.x + distanceBetweenPlatforms+Random.Range(-2f,5f), secondY, 0);
                gOToDestroy2.Add(newPlatform2);
                if (gOToDestroy2.Count > 4)
                {
                    Destroy(gOToDestroy2[0]);
                    gOToDestroy2.RemoveAt(0);

                }
            }
        }
    }
}
