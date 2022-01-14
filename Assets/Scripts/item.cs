using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SimpleInventory : MonoBehaviour
{

    [SerializeField]
    GameObject iconPrefab = null;
    [SerializeField]
    Transform iconParent = null;
    [SerializeField]
    InventoryItem[] items = null;
    // アイテムを持ってるかどうかのフラグ
    bool[] itemFlags;
    // アイテムのアイコンを管理するためのディクショナリ
    Dictionary<int, GameObject> icons = new Dictionary<int, GameObject>();
    void Start()
    {
        itemFlags = new bool[items.Length];
    }
    // アイテムを持ってるかどうかを確認するメソッド
    public bool GetItemFlag(string itemName)
    {
        int index = GetItemIndexFromName(itemName);
        return itemFlags[index];
    }
    public void SetItem(string itemName, bool isOn)
    {
        int index = GetItemIndexFromName(itemName);
        if (!itemFlags[index] && isOn)
        {
            // アイテム未所持の状態で新しく入手したとき
            // 新しいアイコンを生成し、インベントリのキャンバスの子に設定
            GameObject icon = Instantiate(iconPrefab, iconParent);
            // アイコンの画像を設定
            icon.GetComponent<Image>().sprite = items[index].itemSprite;
            icons.Add(index, icon);
        }
        else if (itemFlags[index] && !isOn)
        {
            // アイテム所持中に削除するとき
            GameObject icon = icons[index];
            // アイテムのアイコンを削除
            Destroy(icon);
            // アイコンのディクショナリから対象のアイテムを削除
            icons.Remove(index);
        }
        itemFlags[index] = isOn;
    }
    int GetItemIndexFromName(string itemName)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i].itemName == itemName)
            {
                return i;
            }
        }
        Debug.LogWarning("指定されたアイテム名が間違っているか存在しません");
        return 0;
    }
}
// インベントリに登録できるアイテムを定義するためのクラス
[System.Serializable]
public class InventoryItem
{
    public string itemName = "";
    public Sprite itemSprite = null;
}