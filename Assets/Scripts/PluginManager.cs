﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class PluginManager : MonoBehaviour
{
    public GameObject Player;


    const string DLL_NAME = "EnginesDLL";

    //Methods
    [DllImport(DLL_NAME)]
    private static extern void ResetLogger();

    //Setters
    [DllImport(DLL_NAME)]
    private static extern void SaveCheckpointTime(float RTBC);

    //Getters
    [DllImport(DLL_NAME)]
    private static extern float GetTotalTime();

    [DllImport(DLL_NAME)]
    private static extern float GetCheckpointTime(int index);

    [DllImport(DLL_NAME)]
    private static extern int GetNumCheckpoint();

    float lastTime = 0.0f;


    public void SaveTimeTest(float checkpointTime)
    {
        SaveCheckpointTime(checkpointTime);
    }

    public float LoadTimeTest(int index)
    {
        if (index >= GetNumCheckpoint())
        {
            return -1.0f;
        }
        else
        {
            return GetCheckpointTime(index);
        }
    }
    public float LoadTotalTimeTest()
    {
        return GetTotalTime();
    }
    public void ResetLoggerTest()
    {
        ResetLogger();
    }
    // Start is called before the first frame update
    void Start()
    {
        lastTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //tried to change this to when collision occurs
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float currentTime = Time.time;
            float checkpointTime = currentTime - lastTime;

            SaveTimeTest(checkpointTime);
        }

        for (int i = 0; i < 1; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha0 + i))
            {
                Debug.Log(LoadTimeTest(i));
            }

        }

        if(Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log(LoadTotalTimeTest());
        }
    }
}
