using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{

    [Header("必要なコンポーネントを登録")]
    [SerializeField]
    Canvas lookUpCanvas = null;
    [SerializeField]
    Text lookUpText = null;
    [SerializeField]
    SimpleInventory inventory = null;

    [Header("オブジェクトを調べた時のメッセージを記入")]
    [SerializeField, Multiline]
    string message = "";

    [Header("アイテムを取得できる場合のみ設定")]
    [SerializeField, Space]
    bool getItem = false;
    [SerializeField]
    bool itemRequired = false;
    [SerializeField]
    string getItemName = "";
    [SerializeField, Multiline]
    string getItemMessage = "";

    [Header("アイテムを使う場合のみ設定")]
    [SerializeField, Space]
    bool useItem = false;
    [SerializeField]
    string useItemName = "";
    [SerializeField, Multiline]
    string useItemMessage = "";
    [SerializeField]
    bool gameClear = false;
    [SerializeField]
    Button closeButton = null;

    // 既にアイテムを取得したかどうかのフラグ
    // これがないと何度もアイテムを入手出来てしまう
    bool itemIsAcquired = false;
    bool itemUsed = false;

    public void LookUp()
    {
        lookUpCanvas.enabled = true;
        lookUpText.text = message;

        if (useItem && inventory.GetItemFlag(useItemName))
        {
            lookUpText.text += "\n\n" + useItemMessage;

            inventory.SetItem(useItemName, false);

            if (gameClear)
            {
                // 「閉じる」ボタンのイベントを削除して、新しくタイトルに戻るためのイベントを追加する
                //closeButton.onClick.RemoveAllListeners();
                //closeButton.onClick.AddListener(() => GameObject.FindGameObjectWithTag("GameController").GetComponent<MoveSceneManager>().MoveToScene(0));
            }

            itemUsed = true;
        }

        if (getItem && !itemIsAcquired)
        {
            if (itemRequired && !itemUsed)
            {
                return;
            }

            lookUpText.text += "\n\n" + getItemMessage;

            inventory.SetItem(getItemName, true);

            itemIsAcquired = true;
        }
    }

}
