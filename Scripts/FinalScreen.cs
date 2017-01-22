using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScreen : MonoBehaviour
{
    void OnEnable()
    {
        Manager.current.NewSchedule();
    }
}
