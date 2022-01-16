using UnityEngine;

public class item_check : MonoBehaviour
{
    [Header("どのアイテムを持っているかを確認できるglobalな関数")]
    public static bool key_a = false;
    public bool key_1;

    void Update()
    {
        key_1 = key_a;
    }
}