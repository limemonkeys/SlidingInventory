using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPosition : MonoBehaviour
{
    public Transform startPosition;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = startPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
