using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalTime : MonoBehaviour
{
    [SerializeField] public GameObject TimeDisplay;
    public static float TimePassed;

    //private void Start()
    //{
    //    startTime = Time.timeSinceLevelLoad;
    //}

    //private void Update()
    //{
    //    float currentTime = Time.timeSinceLevelLoad - startTime;
    //}

    void Update()
    {
        TimePassed = Time.timeSinceLevelLoad;

        TimeDisplay.GetComponent<UnityEngine.UI.Text>().text = "Time: " + TimePassed;
    }
}
