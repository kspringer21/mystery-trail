using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// this allows us to load the scene in ActivateEvent

public class EventManager : MonoBehaviour
{
    double minimumDistanceToAccess = 0.1;


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
                    SceneManager.LoadScene("PylonsInfo");
                }
                else
                {
                    if(eventID == 4)
                    {
                        SceneManager.LoadScene("NewmanInfo");
                    }
                    else
                    {
                        if(eventID == 5)
                        {
                            SceneManager.LoadScene("BookstoreInfo");
                        }
                        else
                        {
                            if(eventID == 6)
                            {
                                SceneManager.LoadScene("SquiresInfo");
                            }
                        }
                    }
                }
            }
        }


    }


    public double getMinimumDistanceToAccess() {
        return minimumDistanceToAccess;
    }

}
