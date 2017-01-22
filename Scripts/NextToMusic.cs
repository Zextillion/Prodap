using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextToMusic : MonoBehaviour
{
    [SerializeField]
    GameObject currentScreen;
    [SerializeField]
    GameObject nextScreen;
    [SerializeField]
    GameObject finalScreen;
    private Animator animator;

    void Awake()
    {
        animator = transform.parent.GetComponent<Animator>();
    }

	void OnMouseDown()
    {
        if (Manager.current.likesMusic == true)
        {
            nextScreen.SetActive(true);
        }
        else
        {
            finalScreen.SetActive(true);
        }
        currentScreen.GetComponent<Animator>().SetBool("Exit", true);
    }
}
