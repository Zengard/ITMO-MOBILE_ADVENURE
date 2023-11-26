using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameAnalyticsSDK;

public class GAManager : MonoBehaviour  
{
    public static GAManager instance;

    private void Awake()
    {
        instance = this;

        DontDestroyOnLoad(this);
    }

    void Start()
    {
        GameAnalytics.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnLevelComplite(int _level)
    {
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "Level: " + _level);
        Debug.Log("Level: " + _level);
    }


    public void OnLevelFail(int _level)
    {
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Fail, "Level: " + _level);
        Debug.Log("Fail Level: " + _level);
    }
}
