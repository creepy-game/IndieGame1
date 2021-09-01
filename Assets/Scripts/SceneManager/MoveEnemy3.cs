using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour
{

    public Transform goal;          //目的地となるオブジェクトのトランスフォーム格納用
    private NavMeshAgent agent;     //エージェントとなるオブジェクトのNavMeshAgent格納用 

    // Use this for initialization
    void Start()
    {
        //エージェントのNaveMeshAgentを取得する
        agent = GetComponent<NavMeshAgent>();
        //目的地となる座標を設定する
        agent.destination = goal.position;
    }
    if (elapsedTime > freezeTimeAfterAttack)
    {
        SetState(EnemyState.Walk);
}

    else if (state == EnemyState.Attack)
{
    //　プレイヤーの方向を取得
    var playerDirection = new Vector3(playerTransform.position.x, transform.position.y, playerTransform.position.z) - transform.position;
    //　敵の向きをプレイヤーの方向に少しづつ変える
    var dir = Vector3.RotateTowards(transform.forward, playerDirection, rotateSpeed * Time.deltaTime, 0f);
    //　算出した方向の角度を敵の角度に設定
    transform.rotation = Quaternion.LookRotation(dir);
}

}