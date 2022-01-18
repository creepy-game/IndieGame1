using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Feel_base : MonoBehaviour
{
    public float TheDistance;
    public GameObject ThePlayer;
    public GameObject TextBox;
    [SerializeField, Multiline]
    string feel_message = "";
    bool feel_a = true;

    void OnTriggerStay(Collider other)
    {

        // 衝突した相手にPlayerタグが付いているとき
        if (other.gameObject.tag == "Player" && feel_a)
        {
            StartCoroutine(dd());
            feel_a = false;
            Debug.Log("入った");

        }

    }

    IEnumerator dd()
    {
        TextBox.GetComponent<Text>().text = feel_message;
        yield return new WaitForSeconds(5);
        TextBox.GetComponent<Text>().text = "";
    }
}