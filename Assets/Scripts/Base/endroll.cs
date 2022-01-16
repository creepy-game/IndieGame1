using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
 
public class endroll : MonoBehaviour
{
    [Header("エンドロールでtextの流す速度などの調整")]

    [Tooltip("テキストのスクロールスピード")]
    [SerializeField]
    private float textScrollSpeed = 30;

    [Tooltip("テキストの制限位置")]
    [SerializeField]
    private float limitPosition = 730f;

    [Tooltip("エンドロールが終了したかどうか")]
    private bool isStopEndRoll;

    [Tooltip("シーン移動用コルーチン")]
    private Coroutine endRollCoroutine;

    // Update is called once per frame
    void Update()
    {
        //　エンドロールが終了した時
        if (isStopEndRoll)
        {
            endRollCoroutine = StartCoroutine(GoToNextScene());
        }
        else
        {
            //　エンドロール用テキストがリミットを越えるまで動かす
            if (transform.position.y <= limitPosition)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + textScrollSpeed * Time.deltaTime);
            }
            else
            {
                isStopEndRoll = true;
            }
        }
    }

    IEnumerator GoToNextScene()
    {
        //　5秒間待つ
        yield return new WaitForSeconds(5f);

        if (Input.GetKeyDown("space"))
        {
            StopCoroutine(endRollCoroutine);
            SceneManager.LoadScene("scene_packege");
        }

        yield return null;
    }
}
