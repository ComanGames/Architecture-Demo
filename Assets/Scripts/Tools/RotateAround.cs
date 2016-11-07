using UnityEngine;

namespace Tools
{
    public class RotateAround : BaseAnimation 
    {
        private void Update()
        {
            transform.RotateAround(transform.position,Vector3.up,Curve.Evaluate((transform.eulerAngles.y+180)/360)*Speed/Time.deltaTime);

        }
    }
}