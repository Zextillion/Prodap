using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager current;

    public int sleepHours;
    public int workHours;
    public int freeTimeHours = 24;

    public bool likesMusic = false;
    public bool likesGaming = false;
    public bool likesTV = false;
    public bool likesYoutube = false;
    public bool likesSocialMedia = false;
    public bool likesExercising = false;

    public bool likesEDM = false;
    public bool likesRap = false;
    public bool likesPop = false;
    public bool likesRock = false;

    void Awake()
    {
        current = this;
    }

    public void PrintMessage()
    {
        SleepMessage();
        WorkMessage();
        CalculateFreeTime();
    }

    void SleepMessage()
    {
        if (sleepHours < 7)
        {
            Debug.Log("ayyyy fam u should get more sleep");
        }
        else if (sleepHours <= 10)
        {
            Debug.Log("u good fam");
        }
        else if (sleepHours > 10)
        {
            Debug.Log("y u so lazy");
        }
    }

    void WorkMessage()
    {
        if (workHours < 7)
        {
            Debug.Log("ayyyy fam u should get more work");
        }
        else if (workHours <= 10)
        {
            Debug.Log("u good work fam");
        }
        else if (workHours > 10)
        {
            Debug.Log("y u so lazy work");
        }
    }

    void CalculateFreeTime()
    {
        freeTimeHours = 24 - sleepHours - workHours;
        Debug.Log("You have " + freeTimeHours + " hours in your day");
    }

    public void HobbyMessage()
    {
        if (likesMusic == true)
        {
            MusicMessage();
        }
        NewSchedule();
    }

    void MusicMessage()
    {
        Debug.Log("What do you enjoy listening to?");
    }

    public void NewSchedule()
    {
        Debug.Log("In order to cut back wasteful time, do these steps: ");
        if (likesMusic == true)
        {
            if (likesEDM == true)
            {
                Debug.Log("Learn how to make EDM music");
            }
            if (likesRap == true)
            {
                Debug.Log("Learn how to make fire mixtapes");
            }
            if (likesPop == true)
            {
                Debug.Log("Learn how to sing");
            }
            if (likesRock == true)
            {
                Debug.Log("Learn how to guitar/bass");
            }
        }

        if (likesGaming == true)
        {
            Debug.Log("At least learn how to stream on Twitch");
            Debug.Log("Have you considered Game development?");
        }

        if (likesTV == true)
        {
            Debug.Log("Write fanfiction or something idk");
        }

        if (likesYoutube == true)
        {
            Debug.Log("Grab a camera, grab a decent microphone, go ham");
        }

        if (likesSocialMedia == true)
        {
            Debug.Log("Go out and give to the community by doing charity or something");
        }

        if (likesExercising == true)
        {
            Debug.Log("Congratulations, that's healthy, keep exercising");
        }

        FinalMessage();
    }

    void FinalMessage()
    {
        Debug.Log("Remember, just filling out this app doesn't mean your schedule is automatically fixed. The hardest part of keeping this schedule is having the willpower to continue doing it instead of lazing around. If you want to cut back on your unproductive time, you will have to find a hobby that is not only productive, but also fun for you!");
    }
}
