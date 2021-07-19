using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploreMapManager : MonoBehaviour
{
    public Camera TrackerCamera;
    public Transform TrackedPlayer;
    public Transform PlayerIndicator;

    // Start is called before the first frame update
    void Start()
    {
        TrackerCamera.clearFlags = CameraClearFlags.Nothing;
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
