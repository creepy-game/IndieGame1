using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_check : MonoBehaviour
{
    public static bool key_a = false;
    public bool key_1;

    void Update()
    {
        key_1 = key_a;
    }

}