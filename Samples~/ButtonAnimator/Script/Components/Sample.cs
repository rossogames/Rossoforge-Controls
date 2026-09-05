using Rossoforge.Utils.Logger;
using UnityEngine;

namespace Rossoforge.Controls.Samples.ButtonAnimator
{
    public class Sample : MonoBehaviour
    {
        private void Start()
        {
            RossoLogger.Level = LogLevel.Verbose;
        }


        public void OnButton1Click()
        {
            Debug.LogWarning("Button 1 Clicked");
        }

        public void OnButton2Click()
        {
            Debug.LogWarning("Button 2 Clicked");
        }

        public void OnButton3Click()
        {
            Debug.LogWarning("Button 3 Clicked");
        }

        public void OnButton4Click()
        {
            Debug.LogWarning("Button 4 Clicked");
        }
    }
}
