using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Init the movement speed of camera and player 
    public float cameraSpeed = 2.0f;
    public float movementSpeed = 2.0f;

    // Start is called before the first frame update 
    void Start()
    {

    }

    // Update is called once per frame 
    void Update()
    {
        //Moving Camera using WASD 
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, -movementSpeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(movementSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, movementSpeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(-movementSpeed * Time.deltaTime, 0, 0));
        }

        ////Rotating Camera
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    transform.Rotate(new Vector3(0, -90, 0));
        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    transform.Rotate(new Vector3(0, 90, 0));
        //}
    }
}
