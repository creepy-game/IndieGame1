using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Item_key_a : MonoBehaviour
{
    [Header("鍵を拾う時用のスクリプト")]
    public float TheDistance;
    public GameObject ThePlayer;
    public GameObject Cmd_find;
    public GameObject Light;
    public GameObject TextBox;
    [SerializeField, Multiline]
    string getItemMessage = "";
    bool aa = true;
    bool key_flag = true;

    void OnMouseOver()
    {
        if (TheDistance <= 10 && aa && key_flag)
        {
            Cmd_find.SetActive(true);
        }

        if (Input.GetButtonDown("Find"))//t:Keyを割り当てている
        {
            if (TheDistance <= 10)
            {
                Cmd_find.SetActive(false);
                TextBox.SetActive(true);
                Light.SetActive(false);
                aa = false;
                item_check.key_a = true;
                key_flag = false;
                StartCoroutine(cc());
            }
        }

        IEnumerator cc()
        {
            yield return new WaitForSeconds(1.5f);
            TextBox.GetComponent<Text>().text = getItemMessage;

            yield return new WaitForSeconds(2);
            TextBox.GetComponent<Text>().text = "";
        }
    }

    void OnMouseExit()
    {
        Cmd_find.SetActive(false);
    }
}