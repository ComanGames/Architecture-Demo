using System;
using Tools;
using UnityEngine;

namespace Stages
{
    public interface IStage
    {
         Action OnEnd { get; set; }
          void StartStage();
          void EndStage();
    }
}