using System.Collections;
using UnityEngine;

public class Chase_notice_circle : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        Debug.Log("円状から見失った.");
        StartCoroutine("Notice");
    }

    void OnTriggerStay(Collider other)
    {
        if (other.name == "FPSController")
        {
            Debug.Log("円の中に発見された.");
            Chase_hub.n_cir = true;
        }
    }

    IEnumerator Notice()
    {
        yield return new WaitForSeconds(10);//15sの追跡
        Chase_hub.n_cir = false;
        Debug.Log("円の中から逃げ切った.");
    }

}
