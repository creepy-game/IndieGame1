using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]

public class Chase_enemy : MonoBehaviour
{
    [SerializeField]
    [Tooltip("追いかける対象")]
    private Transform player;
    private NavMeshAgent navMeshAgent;
    // 巡回地点オブジェクトを格納する配列
    public Transform[] points;
    // 巡回地点のオブジェクト数（初期値=0）
    private int destPoint = 0;
    // NavMesh Agent コンポーネントを格納する変数
    private NavMeshAgent agent;

    // ゲームスタート時の処理
    void Start()
    {
        // 変数"agent"に NavMesh Agent コンポーネントを格納
        agent = GetComponent<NavMeshAgent>();
        // 巡回地点間の移動を継続させるために自動ブレーキを無効化
        agent.autoBraking = false;
        // 次の巡回地点の処理を実行
        GotoNextPoint();
    }

    // 次の巡回地点を設定する処理
    void GotoNextPoint()
    {
            // 巡回地点が設定されていなければ
            if (points.Length == 0)
                // 処理を返します
                return;
            // 現在選択されている配列の座標を巡回地点の座標に代入
            agent.destination = points[destPoint].position;
            // 配列の中から次の巡回地点を選択（必要に応じて繰り返し）
            destPoint = (destPoint + 1) % points.Length;
        }
    
    void Update()
    {
        // 散策モード
        if (!agent.pathPending && agent.remainingDistance < 0.5f && !Chase_hub.n_line && !Chase_hub.n_cir && !Chase_hub.n_sou && !Chase_hub.n_act)
        {
            agent.speed = 2;
            GotoNextPoint();
        }

        // 追いかけモード(直線)
        if (Chase_hub.n_line)
        {
            agent.destination = player.transform.position;
            agent.speed = 4;
        }

        // 追いかけモード(円環)
        if (Chase_hub.n_cir)
        {
            agent.destination = player.transform.position;
            agent.speed = 2;
        }

        // 追いかけモード(音)
        if (Chase_hub.n_sou)
        {
            agent.destination = player.transform.position;
            agent.speed = 10;
        }

        // 追いかけモード(動作)
        if (Chase_hub.n_act)
        {
            agent.destination = player.transform.position;
            agent.speed = 100;
        }


    }
}