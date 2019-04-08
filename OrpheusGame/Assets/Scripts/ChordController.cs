using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChordController : MonoBehaviour
{
    public GameObject ChordImage;
    public GameObject player;
    float width;

    List<GameObject> chordImageLists;
    public void Start()
    {
        chordImageLists = new List<GameObject>();

        GameObject initChordImage = Instantiate(ChordImage);
        chordImageLists.Add(initChordImage);
        width = initChordImage.GetComponent<SpriteRenderer>().bounds.size.x;
        Debug.Log(width);
        initChordImage.transform.position = new Vector3(0, 0,0);

    }
    public void Update()
    {
        if (chordImageLists.Count > 5)
        {
            Destroy(chordImageLists[0]);
            chordImageLists.RemoveAt(0);
        }
        else if (chordImageLists[0].transform.position.x < player.transform.position.x-2*width)
        {

            GameObject newChordImage = Instantiate(ChordImage);
            newChordImage.transform.position = 
            new Vector3(chordImageLists[chordImageLists.Count-1].transform.position.x+width, 0,0);
            newChordImage.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            chordImageLists.Add(newChordImage);
        }
    }
}