using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //シーン遷移させる場合に必要

public class PlayerMove3 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goal")
        {
            SceneManager.LoadScene("Stage3");
        }
    }
}
