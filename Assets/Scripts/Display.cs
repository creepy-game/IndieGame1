using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Display : MonoBehaviour
{
    public float TheDistance;
    [Header("Cmd")]
    public GameObject CmdFindText;
    public GameObject CmdReturnText;
    public GameObject ThePlayer;

    [Header("Item")]
    public GameObject Item;
    public GameObject Expalain;
    public GameObject Picture;
    public GameObject Light;
    bool aa;
    bool key = false;

    public GameObject TextBox;
    [SerializeField, Multiline]
    string getItemMessage = "";

 
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
        if (Input.GetButtonDown("Return"))//r:Keyを割り当てている
        {
            Expalain.SetActive(false);
            Picture.SetActive(false);
            CmdReturnText.SetActive(false);
            ThePlayer.GetComponent<FirstPersonController>().enabled = true;
            CmdFindText.SetActive(false);
            aa = true;
        }

    }

    void OnMouseOver()
    {
        if (TheDistance <= 10 && aa)
        {
            CmdFindText.SetActive(true);
        }

        if (Input.GetButtonDown("Find"))//t:Keyを割り当てている
        {
            if (TheDistance <= 10)
            {
                CmdFindText.SetActive(false);
                Expalain.SetActive(true);
                Picture.SetActive(true);
                CmdReturnText.SetActive(true);
                ThePlayer.GetComponent<FirstPersonController>().enabled = false;
                aa = false;
                TextBox.GetComponent<Text>().text = getItemMessage;
                Light.SetActive(false);
                key = true;
            }
        }
    }

    void OnMouseExit()
    {
        CmdFindText.SetActive(false);
    }
}