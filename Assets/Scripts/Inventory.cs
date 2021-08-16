using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] Transform content;
    [SerializeField] GameObject imagePrefab;
    List<Goods> inventory = new List<Goods>();

    static Inventory instance;
    public static Inventory GetInstance()
    {
        return instance;
    }

    // アイテムを取得するメソッド
    public void Obtain(Obtainable item)
    {
        // アイテムの存在を確認
        if (ItemManager.GetInstance().HasItem(item.GetItemName()))
        {
            GameObject goodsObj = Instantiate(imagePrefab, content); // Imageインスタンスを作る
            Goods goods = goodsObj.GetComponent<Goods>(); // スクリプトを取得
            goods.SetUp(item); // 画像などを設定
            item.GetGameObject().SetActive(false); // アイテムを非アクティブにする
            inventory.Add(goods); // リストに入れる

            TextManager.GetInstance().SetText(item.GetItemName() + "を取得した", 2);
        }
        else
        {
            TextManager.GetInstance().SetText("アイテム名が無効", 2);
        }
    }
    private void Awake()
    {
        instance = this;
    }

}