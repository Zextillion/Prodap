using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSelector : MonoBehaviour
{ 
    public bool edm = false;
    public bool rock = false;
    public bool pop = false;
    public bool rap = false;
    
    void OnMouseDown()
    {
        if (edm == true)
        {
            Manager.current.likesEDM = true;
        }
        else if (rock == true)
        {
            Manager.current.likesRock = true;
        }
        else if (pop == true)
        {
            Manager.current.likesPop = true;
        }
        else if (rap == true)
        {
            Manager.current.likesRap = true;
        }
    }
}
