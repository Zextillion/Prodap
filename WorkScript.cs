using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkScript : MonoBehaviour
{
    [SerializeField]
    int workHours = 0;

    void OnMouseDown()
    {
        Manager.current.workHours = workHours;
        Manager.current.PrintMessage();
    }
}
