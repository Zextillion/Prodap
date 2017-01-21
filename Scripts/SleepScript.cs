using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepScript : MonoBehaviour
{
    [SerializeField]
    int sleepHours = 0;

    void OnMouseDown()
    {
        Manager.current.sleepHours = sleepHours;
    }
}
