using UnityEngine;

namespace Tools
{
    public class TextureShow : BaseAnimation
    {
        public Material OurMaterial;
        [Range(0,1)]
        public float AlphaMax;
        [Range(0, 1)]
        public float AlphaMin;
        private Color _realColor;
        private bool _show = true;

        public void Start()
        {
            _realColor = OurMaterial.color;
        }


        public void Update()
        {
            float step = Curve.Evaluate((_realColor.a)) * Speed / Time.deltaTime;


            if (_show)
            {
                if (_realColor.a + step > AlphaMax)
                    _show = false;
                else
                    _realColor.a += step;
            }
            else
            {

                if (_realColor.a - step < AlphaMin)
                {
                    _show = true;
                }
                else
                    _realColor.a -= step;

            }



            OurMaterial.color  =_realColor;

        }


    }
}