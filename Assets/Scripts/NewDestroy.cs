using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewDestroy : MonoBehaviour
{
    public GameObject DestoroyObject;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(collision.gameObject);
        }
    }

}