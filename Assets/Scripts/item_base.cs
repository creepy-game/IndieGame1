using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Item_base : MonoBehaviour
{
    public float TheDistance;
    public GameObject Cmd_FindText;
    public GameObject Cmd_ReturnText;
    public GameObject Item_Photo;
    public GameObject Item_Panel;
    public GameObject ThePlayer;
    public GameObject TextBox;
    [SerializeField, Multiline]
    string getItemMessage = "";
    bool aa = true;//Cmd_FindTextがアイテムを入手panelが出た際に見えなくなる用.

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
        if (Input.GetButtonDown("Return"))//r:Keyを割り当てている
        {
            Item_Photo.SetActive(false);
            Item_Panel.SetActive(false);
            Cmd_ReturnText.SetActive(false);
            Cmd_FindText.SetActive(false);
            ThePlayer.GetComponent<FirstPersonController>().enabled = true;
            aa = true;
        }
    }

    void OnMouseOver()
    {
        if (TheDistance <= 10 && aa)
        {
            Cmd_FindText.SetActive(true);
        }

        if (Input.GetButtonDown("Find"))//t:Keyを割り当てている
        {
            if (TheDistance <= 10)
            {
                Cmd_FindText.SetActive(false);
                Item_Photo.SetActive(true);
                Item_Panel.SetActive(true);
                Cmd_ReturnText.SetActive(true);
                ThePlayer.GetComponent<FirstPersonController>().enabled = false;
                aa = false;
                Cmd_FindText.SetActive(true);
                TextBox.GetComponent<Text>().text = getItemMessage;
            }
        }
    }

    void OnMouseExit()
    {
        Cmd_FindText.SetActive(false);
    }
}