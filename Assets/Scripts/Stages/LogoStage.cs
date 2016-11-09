using System;
using UnityEngine;

namespace Stages
{
    public class LogoStage :MonoBehaviour,IStage 
    {
        public Action OnEnd { get; set; }
        public void StartStage()
        {
        }

        public void EndStage()
        {
        }
    }
}