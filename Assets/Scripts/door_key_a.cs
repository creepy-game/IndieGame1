using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class door_key_a : MonoBehaviour
{
    public float TheDistance;
    public GameObject TextBox;
    public GameObject Cmd_Action;
    public GameObject TheDoor;
    public AudioSource CreaakSound;
    [SerializeField, Multiline]
    string Action_Message = "";

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            Cmd_Action.SetActive(true);
            TextBox.SetActive(true);
            TextBox.GetComponent<Text>().text = Action_Message;

        }

        if (Input.GetButtonDown("Action"))
        {
            if(TheDistance <= 2 && Item_hub.key_a)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                Cmd_Action.SetActive(false);
                TextBox.SetActive(false);
                TheDoor.GetComponent<Animation>().Play("FirstDoorOpenAnim");
                CreaakSound.Play();
            }
            else
            {
                Debug.Log("a");
            }
        }
    }

    void OnMouseExit()
    {
        Cmd_Action.SetActive(false);
        TextBox.SetActive(false);
    }
   
}
