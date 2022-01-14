using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager4 : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Stage1");
    }
}