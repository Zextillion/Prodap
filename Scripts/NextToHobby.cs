using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextToHobby : MonoBehaviour
{
    [SerializeField]
    GameObject currentScreen;
    [SerializeField]
    GameObject nextScreen;
    [SerializeField]
    Sprite image;

    [SerializeField]
    string url1;
    [SerializeField]
    string url2;
    [SerializeField]
    string url3;

    void OnMouseDown()
    {
        nextScreen.SetActive(true);
        nextScreen.GetComponent<SpriteRenderer>().sprite = image;

        nextScreen.GetComponent<URLController>().SetURL(0, url1);

        nextScreen.GetComponent<URLController>().SetURL(1, url2);

        nextScreen.GetComponent<URLController>().SetURL(2, url3);
        
        currentScreen.GetComponent<Animator>().SetBool("Exit", true);
        currentScreen.SetActive(false);
    }
}
