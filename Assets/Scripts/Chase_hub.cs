using UnityEngine;

public class Chase_hub : MonoBehaviour
{
    [Header("敵に気づかせて追わせるためのスクリプト")]
    public static bool n_cir = false;
    public static bool n_line = false;
    public static bool n_sou = false;
    public static bool n_act = false;


    public bool notice_circle;
    public bool notice_line;
    public bool notice_sound;
    public bool notice_action;


    void Update()
    {
        notice_circle = n_cir;
        notice_line = n_line;
        notice_sound = n_sou;
        notice_action = n_act;
    }
}