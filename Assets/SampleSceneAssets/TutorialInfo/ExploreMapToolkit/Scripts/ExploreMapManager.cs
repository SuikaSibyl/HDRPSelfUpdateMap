using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExploreMapManager : MonoBehaviour
{
    public Camera TrackerCamera;
    public Transform TrackedPlayer;
    public Transform PlayerIndicator;
    public float ExploreRadius = 1;

    ParticleSystem trajectory;

    public void StartSystem()
    {
        trajectory.Play(true);
    }

    public void DisableSystem()
    {
        trajectory.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
    }

    public void SetExploreRadius(float radius)
    {
        ExploreRadius = radius;
        PlayerIndicator.localScale = new Vector3(radius, radius, radius);
    }
    // Start is called before the first frame update
    void Start()
    {
        trajectory = PlayerIndicator.GetChild(0).GetComponent<ParticleSystem>();
        SetExploreRadius(2);
    }

    void FixedUpdate()
    {
        PlayerIndicator.position = TrackedPlayer.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
