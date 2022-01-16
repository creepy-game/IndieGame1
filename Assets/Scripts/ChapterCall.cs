using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class ChapterCall : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject chapter;
    public GameObject Panel;

 void Start()
    {
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
        yield return new WaitForSeconds(4);
        chapter.SetActive (false);
        Panel.SetActive (false);

        ThePlayer.GetComponent<FirstPersonController>().enabled = true;
    }
}
