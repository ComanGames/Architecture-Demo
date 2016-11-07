using System;
using UnityEngine;

namespace Stages
{
    [Serializable]
    public class BaseStage:MonoBehaviour
    {
        Action OnEnd { get; set; }

        public virtual void Play()
        {
            
        }
        
    }
}