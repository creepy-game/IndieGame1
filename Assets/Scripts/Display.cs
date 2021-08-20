using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject TheDoor;
    public AudioSource CreaakSound;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;

        if (Input.GetButtonDown("Return"))
        {
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
        }

    }

    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);

        }

        if (Input.GetButtonDown("Return"))
        {
            if (TheDistance <= 2)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                CreaakSound.Play();
            }
        }
    }
    
   
    
}
