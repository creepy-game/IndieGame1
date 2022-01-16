using UnityEngine;

public class Item_hub : MonoBehaviour
{
    [Header("どのアイテムを持っているかを確認できるglobalな関数")]
    public static bool key_a = false;
    public bool key_1;

    void Update()
    {
        key_1 = key_a;
    }
}