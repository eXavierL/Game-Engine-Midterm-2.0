using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Reference from this video: https://www.youtube.com/watch?v=7nxpDwnU0uU

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 0, 90));
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, 0, -90));
        }

    }
}
