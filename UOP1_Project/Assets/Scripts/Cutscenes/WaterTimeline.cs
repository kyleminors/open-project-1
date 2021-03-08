using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

[ExecuteAlways]
public class WaterTimeline : MonoBehaviour
{
	public PlayableTrack playable;

	public Material ocean;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
	    ocean.SetFloat("", (float)playable.duration);
	   // Debug.Log(playable.duration);
    }
}
