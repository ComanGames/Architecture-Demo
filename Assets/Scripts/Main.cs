using System.Collections.Generic;
using Stages;
using UnityEngine;
using Vuforia;

public class Main : MonoBehaviour
{
    public DefaultTrackableEventHandler TrackableEventHandler;
    public Transform Stages;
    private IStage[] _stages;
    private static Main _instance;
    private static bool IsFirst = true;
    //public Variables
    public void Start()
    {
        _instance = this;
        HideStages();
        GetStages();
    }

    private void GetStages()
    {
        List<IStage> stages = new List<IStage>();
        for (int i = 0; i < Stages.childCount; i++)
        {
            IStage component = Stages.GetChild(i).GetComponent<IStage>();
            if(component!=null)
                stages.Add(component);
        }
        _stages = stages.ToArray();
    }

    private void HideStages()
    {
        Renderer[] renderers = Stages.GetComponentsInChildren<Renderer>();
        foreach (Renderer render in renderers)
            render.enabled = false;
    }

    private void ShowStages() {
        Renderer[] renderers = Stages.GetComponentsInChildren<Renderer>();
        foreach (Renderer render in renderers)
            render.enabled = true;

    }

    private void StartFirst()
    {
        _stages[0].StartStage();
    }

    public static void StartTracking()
    {
            _instance.ShowStages();
        if (IsFirst)
        {
            _instance.StartFirst();
            IsFirst = false;
        }

    }

    public static void StopTracking() {
        if(!IsFirst)
        _instance.HideStages();
    }


}