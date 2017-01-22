using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HobbySelector : MonoBehaviour
{
    public bool media = false;
    public bool gaming = false;
    public bool socialMedia = false;
    public bool music = false;
    public bool noHobbies = false;
    
    void OnMouseDown()
    {
        if (gaming == true)
        {
            Manager.current.likesGaming = true;
        }
        else if (media == true)
        {
            Manager.current.likesMedia = true;
        }
        else if (socialMedia == true)
        {
            Manager.current.likesSocialMedia = true;
        }
        else if (music == true)
        {
            Manager.current.likesMusic = true;
        }
        else if (noHobbies == true)
        {
            Manager.current.likesNoHobbies = true;
        }
    }
}
