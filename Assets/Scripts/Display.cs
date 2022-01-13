using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Display : MonoBehaviour
{
    public float TheDistance;
    public GameObject CmdFindText;
    public GameObject CmdReturnText;
    public GameObject Item_Photo;
    public GameObject Item_Panel;
    public GameObject Expalain;
    public GameObject ThePlayer;
    [Header("アイテムを使う場合のみ設定")]
    public GameObject TextBox;
    [SerializeField, Multiline]
    string getItemMessage = "";
    bool aa = true;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
        if (Input.GetButtonDown("Return"))//r:Keyを割り当てている
        {
            Expalain.SetActive(false);
            Item_Photo.SetActive(false);
            Item_Panel.SetActive(false);
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
                Item_Photo.SetActive(true);
                Item_Panel.SetActive(true);
                CmdReturnText.SetActive(true);
                ThePlayer.GetComponent<FirstPersonController>().enabled = false;
                aa = false;
                TextBox.GetComponent<Text>().text = getItemMessage;

            }
        }
    }

    void OnMouseExit()
    {
        CmdFindText.SetActive(false);
    }
}