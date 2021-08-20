using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PickUpPistol : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisPlay;
    public GameObject ActionText;
    public GameObject FakePistol;
    public GameObject RealPistal;
    public GameObject GuideArrow;
    public GameObject ExtraCross;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;

    }
}
