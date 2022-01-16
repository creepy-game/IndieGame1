using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //シーン遷移させる場合に必要

public class LoadScene : MonoBehaviour
{
    public Scene Load_scene;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goal")
        {
            SceneManager.LoadScene(Load_scene);
        }
    }
}
