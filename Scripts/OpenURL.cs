using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    public string url;

	void OnMouseDown ()
    {
        Application.OpenURL(url);
    }
}
