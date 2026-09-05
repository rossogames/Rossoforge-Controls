using Rossoforge.Controls.ProgressBars;
using UnityEngine;

namespace Rossoforge.Controls.Samples.EventHandlerDemo
{
    public class ProgressBarTest : ProgressBarEventsHandler<ProgressBarTest>
    {
        private void Update()
        {
            if (Input.GetKey(KeyCode.KeypadPlus))
                base.ProgressBar.value += 0.2f * Time.deltaTime;

            if (Input.GetKey(KeyCode.KeypadMinus))
                base.ProgressBar.value -= 0.2f * Time.deltaTime;
        }
    }
}
