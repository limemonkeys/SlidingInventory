using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullInventory : MonoBehaviour
{
    public Transform startMarker;
    public Transform endMarker;
    public float speed = 1.0f;
    private float startTime;
    private float journeyLength;

    private bool finishedLerp;
    void Start() {
        finishedLerp = false;
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }
    void Update() {
        if (!finishedLerp)
        {
            if (Mathf.Abs(endMarker.position.x - transform.position.x) < 0.1)
            {
                transform.position = endMarker.position;
                finishedLerp = true;
                
            }
            else
            {
                finishedLerp = false;
                float distCovered = (Time.time - startTime) * speed;
                float fracJourney = distCovered / journeyLength;
                transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);
            }
        }
    }

    public bool IsFinishedLerp()
    {
        return finishedLerp;
    }

    public void ResetLerp()
    {
        finishedLerp = false;
    }

    public void ResetVars()
    {
        finishedLerp = false;
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }
}
