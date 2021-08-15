using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KARI : MonoBehaviour
{
    GameController gameController;

    // 衝突した
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D " + other.gameObject.name);

        // GameControllerの処理を呼ぶ
        gameController.PlayerCollision(true);
    }

    // 離れた
    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("OnTriggerExit2D " + other.gameObject.name);

        // GameControllerの処理を呼ぶ
        gameController.PlayerCollision(false);
    }


    // Use this for initialization
    void Start()
    {
        GameObject speech = GameObject.FindGameObjectWithTag("speech");

        // ↓だと同じオブジェクトにあることになってますが合ってますか？
        //（同じオブジェクトにあるなら衝突スクリプトを分ける必要無いですがとりあえずそのままにしておきます）
        gameController = gameObject.GetComponent<GameController>();
    }
}

