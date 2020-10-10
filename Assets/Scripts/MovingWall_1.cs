using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall_1 : MonoBehaviour
{
    public Transform MovingWall;
    float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MovingWall.position.x >= 3.0f)
        {
            speed = -1.0f;
        }
        if (MovingWall.position.x <= 0.5f)
        {
            speed = 1.0f;
        }

        MovingWall.Translate(0, speed * Time.deltaTime, 0);
    }
}
