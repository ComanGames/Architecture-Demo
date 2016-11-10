using Tools;
using UnityEngine;

namespace Stages
{
    public class LogoStage : MonoBehaviour, IStage
    {
        private Animator _animator;
        public BaseAnimation Rotation;
        public BaseAnimation TextureBlink;


        public void Start()
        {
            _animator=GetComponent<Animator>();
        }
        public void StartAnimationOver()
        {
            GetComponent<Animator>().enabled = false;
            Rotation.StartAnimation();
            TextureBlink.StartAnimation();

        }

        public void StartStage()
        {
            _animator.SetBool("Start", true);
        }
        public void EndStage()
        {
        }
    }
}