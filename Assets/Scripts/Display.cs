using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    public float TheDistance;
    public GameObject CmdFindText;
    public GameObject CmdReturnText;
    public GameObject Item;
    public GameObject Expalain;
    public GameObject Picture;
    public GameObject ThePlayer;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            CmdFindText.SetActive(true);
        }

        if (Input.GetButtonDown("Find"))//w:Keyを割り当てている
        {
            if (TheDistance <= 2)
            {
                CmdFindText.SetActive(false);
                Expalain.SetActive(true);
                Picture.SetActive(true);
                CmdReturnText.SetActive(true);
            }
        }

        if (Input.GetButtonDown("Return"))//r:Keyを割り当てている
        {
            Expalain.SetActive(false);
            Picture.SetActive(false);
            CmdReturnText.SetActive(false);
        }


    }

    void OnMouseExit()
    {
        CmdFindText.SetActive(false);
    }
}