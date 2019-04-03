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
        RectTransform rt = (RectTransform)initChordImage.transform;
        width = rt.rect.width;
        initChordImage.transform.position = new Vector3(0+width/2, 0,0);

        GameObject initChordImage2 = Instantiate(ChordImage);
        initChordImage2.transform.position = new Vector3(0 + width, 0,0);
        chordImageLists.Add(initChordImage2);


        GameObject initChordImage3 = Instantiate(ChordImage);
        initChordImage3.transform.position = new Vector3(0 + width*1.5f, 0,0);
        chordImageLists.Add(initChordImage3);
    }
    public void Update()
    {
        if (chordImageLists.Count > 5)
        {
            Destroy(chordImageLists[0]);
        }
        else if (chordImageLists[0].transform.position.x < player.transform.position.x - width * 3)
        {
            //GameObject newChordImage = Instantiate(ChordImage);
           ///newChordImage.transform.position =
              //  new Vector3(chordImageLists[chordImageLists.Count].transform.position.x + width, 0,0);
            //newChordImage.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
    }
}