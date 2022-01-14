using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class key_a : MonoBehaviour
{
    public float TheDistance;
    public GameObject Cmd_FindText;
    public GameObject Cmd_ReturnText;
    public GameObject Expalain;
    public GameObject ThePlayer;
    public GameObject Light;
    [Header("アイテムを使う場合のみ設定")]
    public GameObject TextBox;
    [SerializeField, Multiline]
    string getItemMessage = "";
    bool aa = true;
    bool key_flag = true;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
        if (Input.GetButtonDown("Return"))//r:Keyを割り当てている
        {
            Expalain.SetActive(false);
            Cmd_ReturnText.SetActive(false);
            ThePlayer.GetComponent<FirstPersonController>().enabled = true;
            Cmd_FindText.SetActive(false);
            aa = true;   
        }
    }

    void OnMouseOver()
    {
        if (TheDistance <= 10 && aa && key_flag)
        {
            Cmd_FindText.SetActive(true);
        }

        if (Input.GetButtonDown("Find"))//t:Keyを割り当てている
        {
            if (TheDistance <= 10)
            {
                Cmd_FindText.SetActive(false);
                Expalain.SetActive(true);
                Light.SetActive(false);
                Cmd_ReturnText.SetActive(true);
                ThePlayer.GetComponent<FirstPersonController>().enabled = false;
                aa = false;
                TextBox.GetComponent<Text>().text = getItemMessage;
                item_check.key_a = true;
                key_flag = false;
            }
        }
    }

    void OnMouseExit()
    {
        Cmd_FindText.SetActive(false);
    }
}