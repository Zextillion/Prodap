using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLController : MonoBehaviour
{
    public GameObject[] url;

    public void SetURL(int objectNumber, string urlString)
    {
        url[objectNumber].GetComponent<OpenURL>().url = urlString;
    }
}
