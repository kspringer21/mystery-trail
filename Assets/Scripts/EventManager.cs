using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// this allows us to load the scene in ActivateEvent

public class EventManager : MonoBehaviour
{
    double minimumDistanceToAccess = 1.2;


    // Activates event and launches scene if the event is within range and the user selects "join"
    public void ActivateEvent(int eventID)
    {
        if (eventID == 1)
        {
            //SceneManager.LoadScene("SceneForEvent1");
            SceneManager.LoadScene("BurrusInfo");

        }
        else
        {
            if (eventID == 2)
            {
                SceneManager.LoadScene("DrillfieldInfo");
            }
            else
            {
                if (eventID == 3)
                {
                    SceneManager.LoadScene("NewmanInfo");
                }
            }
        }


    }


    public double getMinimumDistanceToAccess() {
        return minimumDistanceToAccess;
    }

}
