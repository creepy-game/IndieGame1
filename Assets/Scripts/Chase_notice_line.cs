using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase_notice_line : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        Debug.Log("直線上から見失った.");
        StartCoroutine("Notice");
    }

    void OnTriggerStay(Collider other)
    {
        if (other.name == "FPSController")
        {
            Debug.Log("直線上に発見された.");
            Chase_hub.n_line = true;
        }
    }

    IEnumerator Notice()
    {
        yield return new WaitForSeconds(15);//15sの追跡
        Chase_hub.n_line = false;
        Debug.Log("直線上から逃げ切った.");
    }

}
