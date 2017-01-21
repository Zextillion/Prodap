using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HobbySelector : MonoBehaviour
{ 
    public bool gaming = false;
    public bool tv = false;
    public bool youtube = false;
    public bool socialMedia = false;
    public bool exercising = false;
    public bool music = false;
    
    void OnMouseDown()
    {
        if (gaming == true)
        {
            Manager.current.likesGaming = true;
        }
        else if (tv == true)
        {
            Manager.current.likesTV = true;
        }
        else if (youtube == true)
        {
            Manager.current.likesYoutube = true;
        }
        else if (socialMedia == true)
        {
            Manager.current.likesSocialMedia = true;
        }
        else if (exercising == true)
        {
            Manager.current.likesExercising = true;
        }
        else if (music == true)
        {
            Manager.current.likesMusic = true;
        }
    }
}
