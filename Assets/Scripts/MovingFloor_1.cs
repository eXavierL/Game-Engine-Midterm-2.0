using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFloor_1 : MonoBehaviour
{
    public Transform MovingFloor;
    float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MovingFloor.position.y == 0.0f)
        {
            speed = -1.5f;
        }
        if (MovingFloor.position.y < -0.5f)
        {
            speed = 1.5f;
        }
        if(MovingFloor.position.y >3.0f)
        {
            speed = -1.5f;
        }
        MovingFloor.Translate(0, 0, speed * Time.deltaTime);
    }
}
