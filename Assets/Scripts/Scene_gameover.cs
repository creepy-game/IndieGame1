using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Scene_gameover : MonoBehaviour
{

    void Update ()
    {
        StartCoroutine(cc());


        IEnumerator cc()
        {
            yield return new WaitForSeconds(5f);
            SceneManager.LoadScene("scene_packege");
        }  
    }
}
