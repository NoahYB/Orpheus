using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public float moveSpeed = 0.1f;

    public GameObject basicPlatform;
    public GameObject startingPlatform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startingPlatform != null)
        {
            startingPlatform.transform.Translate(-0.1f, 0, 0);
        }
    }
}
