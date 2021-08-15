using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject Panel;
    // Use this for initialization
    void Start()
    {
        Panel.SetActive(false);
        GameObject Table = GameObject.FindGameObjectWithTag("table");

        gameObject.GetComponent<KARI>();
        // ↑本題とは関係無いですが、変数に代入していないので意味の無いコードです。
    }

    // 衝突した/離れた時に呼ばれるメソッド
    // 衝突時はisHit=true,離れた時はisHit=false
    public void PlayerCollision(bool isHit)
    {
        Panel.SetActive(isHit);
        // 適宜他の処理を入れる
    }
}



