using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    [SerializeField]
    GameObject currentScreen;
    [SerializeField]
    GameObject nextScreen;

	void OnMouseDown()
    {
        nextScreen.SetActive(true);
        currentScreen.GetComponent<Animator>().SetBool("Exit", true);
        currentScreen.SetActive(false);
    }
}
