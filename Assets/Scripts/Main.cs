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
    //public Variables
    public void Start()
    {
        Main._instance = this;
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

    private void HideStages() {
       Stages.gameObject.SetActive(false); }

    private void ShowStages() {
       Stages.gameObject.SetActive(true); }

    public static void StartTracking() {
        Main._instance.ShowStages(); }
    public static void StopTracking() {
        Main._instance.HideStages(); }


}