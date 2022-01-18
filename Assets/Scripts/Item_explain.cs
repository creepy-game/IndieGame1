using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Item_explain : MonoBehaviour
{
    [Header("ものとか壁とかの観察対象に対し無限に触れるためのスクリプト")]
    public float TheDistance;
    public GameObject ThePlayer;
    public GameObject Cmd_find;
    public GameObject TextBox;
    [SerializeField, Multiline]
    string Message_explain = "";
    bool aa = true;

    void OnMouseOver()
    {
        if (TheDistance <= 10 && aa )
        {
            Cmd_find.SetActive(true);
        }

        if (Input.GetButtonDown("Find"))//t:Keyを割り当てている
        {
            if (TheDistance <= 10)
            {
                Cmd_find.SetActive(false);
                TextBox.SetActive(true);
                aa = false;
                Item_hub.key_a = true;
                StartCoroutine(cc());
            }
        }

        IEnumerator cc()
        {
            yield return new WaitForSeconds(1.5f);
            TextBox.GetComponent<Text>().text = Message_explain;

            yield return new WaitForSeconds(2);
            TextBox.GetComponent<Text>().text = "";
        }
    }

    void OnMouseExit()
    {
        Cmd_find.SetActive(false);
    }
}