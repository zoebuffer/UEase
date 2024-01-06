using UdonSharp;
using UnityEngine;

// Uncomment this line when using in your own scripts.
// using dev.zoebuffer.uease; // UEaseType, UEase

namespace dev.zoebuffer.uease.samples.tweenpositionexample
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public class TweenPositionExample : UdonSharpBehaviour
    {
        [SerializeField]
        [Tooltip("Easing function")]
        private UEaseType easeType;

        [SerializeField, Range(0.1f, 5f)]
        [Tooltip("Animation duration, in seconds")]
        private float animDuration = 2f;

        [SerializeField, Range(-20f, 20f)]
        [Tooltip("Target x position, in world space")]
        private float xDist = 20f;

        [SerializeField, Range(0f, 1f)]
        [Tooltip("Delay before restarting animation cycle, in seconds")]
        private float endDelay = 0.1f;

        [SerializeField]
        [Tooltip("Reverse animation on end.")]
        private bool pingPong = true;

        private Vector3 _startPos;
        private Vector3 _endPos;
        private float _tElapsed;
        private bool _reverse;

        private void Start()
        {
            // Store start position so we can reset to it on animation end.
            _startPos = transform.position;

            // Compute end position so we can lerp to it.
            _endPos = new Vector3(xDist, transform.position.y, transform.position.z);

            // Start animation (infinite loop).
            UpdatePosition();
        }

        public void UpdatePosition()
        {
            _tElapsed += Time.deltaTime;

            if (_tElapsed < animDuration)
            {
                // Normalize time from 0 to 1.
                float tNorm = _tElapsed / animDuration;

                // Compute y-pos for easing function at x=tNorm.
                float t = UEase.Ease(easeType, tNorm);

                // Update object position.
                transform.position = Vector3.Lerp(_startPos, _endPos, t);

                // Repeat on next frame.
                SendCustomEventDelayedFrames(nameof(UpdatePosition), 1);
            }
            else
            {
                // Animation complete.

                // Snap object to end position (can be off by small fraction due to rounding errors).
                transform.position = _endPos;

                // Reset animation timer.
                _tElapsed = 0;

                // Gives us time to see object at final position.
                SendCustomEventDelayedSeconds(nameof(ResetPosition), endDelay);
            }
        }

        public void ResetPosition()
        {
            if (pingPong)
            {
                // Start animating back to previous position.
                _reverse = !_reverse;

                // Recompute start and end pos (if pingpong on we start from previous end).
                var tmp = _startPos;
                _startPos = _endPos;
                _endPos = tmp;
            }

            // Reset object position.
            transform.position = _startPos;

            // Recompute object end position (if changed via editor).
            _endPos = new Vector3(_reverse ? -xDist : xDist, transform.position.y, transform.position.z);

            // Restart animation.
            SendCustomEventDelayedFrames(nameof(UpdatePosition), 1);
        }
    }
}
