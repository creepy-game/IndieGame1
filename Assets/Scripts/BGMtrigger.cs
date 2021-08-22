using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMtrigger : MonoBehaviour
{
    
    public AudioSource StopBGM;
    public AudioSource StartBGM;

    void OnTriggrStay(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            StopBGM .Stop();
            StartBGM.Play();

        }
    }
}
