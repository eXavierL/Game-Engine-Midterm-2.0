using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System.IO;

public class CheckPoint : MonoBehaviour
{
    public int index;

    public GameObject Player;
    public static int newindex = 0;

    //Where to write the times
    string location = "Assets/Times.txt";

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

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Checkpoint")
        newindex++;
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
        if (newindex > index)
        {
            float currentTime = Time.time;
            float checkpointTime = currentTime - lastTime;

            SaveTimeTest(checkpointTime);
            StreamWriter text = new StreamWriter(location, false);
            text.WriteLine(GetCheckpointTime(index));
            index++;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(LoadTotalTimeTest());
        }
    }
}
