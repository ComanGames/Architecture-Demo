using UnityEngine;

namespace UnityTestTools
{
    public class MyTest : MonoBehaviour
    {
        public void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.tag=="ground")
                IntegrationTest.Pass();
            else
            {
                IntegrationTest.Fail();
            }

        }
    }
}
