using System;
using UnityEngine;

namespace Tools
{
    public class BaseAnimation : MonoBehaviour
    {
        public float Speed;
        public AnimationCurve Curve;
        public Action OnEnd;
        private bool _playAnimation;

        public virtual void Start()
        {
            _playAnimation = false;

        }
        public virtual void StartAnimation()
        {
            _playAnimation = true;
        }

        public virtual void Animate()
        {
            
        }

        public void Update()
        {
            if(_playAnimation)
                Animate();
        }
    }
}