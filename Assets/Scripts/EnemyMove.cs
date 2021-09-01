using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class MoveEnemy3 : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent agent;
    //public float speed = 0.01f;
    //public GameObject damageeffect;
    //Vector3 SlimePos;
    //Rigidbody rigid;
    void Start()
    {
        // SlimePos = transform.position;
        // rigid = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        agent.destination = target.position;
        // transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), 0.3f);
        //  transform.position += transform.forward * this.speed;
        // rigid.MovePosition(transform.position + transform.forward * Time.deltaTime);
        // transform.rotation = Quaternion.LookRotation(transform.position - SlimePos);
        //  SlimePos = transform.position;
        //transform.rotation = Quaternion.LookRotation(new Vector3(0, 90, 0));
    }

    if (elapsedTime > waitTime) {
            SetState(EnemyState.Walk);

        //　攻撃後のフリーズ状態
    } else if (state == EnemyState.Freeze)

    elapsedTime += Time.deltaTime;

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

    