using UnityEngine;

namespace dev.zoebuffer.uease
{
    // Source: https://easings.net/
    public static class UEase
    {
        private const float C1      = 1.70158f;
        private const float C2      = C1 * 1.525f;
        private const float C3      = C1 + 1f;
        private const float C4      = (2f * Mathf.PI) / 3f;
        private const float C5      = (2f * Mathf.PI) / 4.5f;
        private const float N1      = 7.5625f;
        private const float D1      = 2.75f;

        /// <summary>
        /// Useful wrapper for dynamically calling easing functions at runtime.
        /// </summary>
        /// <param name="easeType">Easing function type</param>
        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t for selected easing function.</returns>
        public static float Ease(UEaseType easeType, float t)
        {
            switch (easeType)
            {
                case UEaseType.Linear:
                    return t;
                case UEaseType.EaseInSine:
                    return EaseInSine(t);
                case UEaseType.EaseOutSine:
                    return EaseOutSine(t);
                case UEaseType.EaseInOutSine:
                    return EaseInOutSin(t);
                case UEaseType.EaseInQuad:
                    return EaseInQuad(t);
                case UEaseType.EaseOutQuad:
                    return EaseOutQuad(t);
                case UEaseType.EaseInOutQuad:
                    return EaseInOutQuad(t);
                case UEaseType.EaseInCubic:
                    return EaseInCubic(t);
                case UEaseType.EaseOutCubic:
                    return EaseOutCubic(t);
                case UEaseType.EaseInOutCubic:
                    return EaseInOutCubic(t);
                case UEaseType.EaseInQuart:
                    return EaseInQuart(t);
                case UEaseType.EaseOutQuart:
                    return EaseOutQuart(t);
                case UEaseType.EaseInOutQuart:
                    return EaseInOutQuart(t);
                case UEaseType.EaseInQuint:
                    return EaseInQuint(t);
                case UEaseType.EaseOutQuint:
                    return EaseOutQuint(t);
                case UEaseType.EaseInOutQuint:
                    return EaseInOutQuint(t);
                case UEaseType.EaseInExpo:
                    return EaseInExpo(t);
                case UEaseType.EaseOutExpo:
                    return EaseOutExpo(t);
                case UEaseType.EaseInOutExpo:
                    return EaseInOutExpo(t);
                case UEaseType.EaseInCirc:
                    return EaseInCirc(t);
                case UEaseType.EaseOutCirc:
                    return EaseOutCirc(t);
                case UEaseType.EaseInOutCirc:
                    return EaseInOutCirc(t);
                case UEaseType.EaseInBack:
                    return EaseInBack(t);
                case UEaseType.EaseOutBack:
                    return EaseOutBack(t);
                case UEaseType.EaseInOutBack:
                    return EaseInOutBack(t);
                case UEaseType.EaseInElastic:
                    return EaseInElastic(t);
                case UEaseType.EaseOutElastic:
                    return EaseOutElastic(t);
                case UEaseType.EaseInOutElastic:
                    return EaseInOutElastic(t);
                case UEaseType.EaseInBounce:
                    return EaseInBounce(t);
                case UEaseType.EaseOutBounce:
                    return EaseOutBounce(t);
                case UEaseType.EaseInOutBounce:
                    return EaseInOutBounce(t);
                default:
                    return t;
            }
        }

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseInSine(float t)
            => 1f - Mathf.Cos(t * Mathf.PI * 0.5f);

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseOutSine(float t)
            => Mathf.Sin(t * Mathf.PI * 0.5f);

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseInOutSin(float t)
            => -(Mathf.Cos(Mathf.PI * t) - 1f) * 0.5f;

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseInQuad(float t)
            => t * t;

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseOutQuad(float t)
            => 1f - (1f - t) * (1f - t);

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseInOutQuad(float t)
            => t < 0.5f
                ? 2f * t * t
                : 1f - Mathf.Pow(-2f * t + 2, 2f) * 0.5f; 

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseInCubic(float t)
            => t * t * t;

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseOutCubic(float t)
            => 1f - Mathf.Pow(1f - t, 3f);

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseInOutCubic(float t)
            => t < 0.5f
                ? 4f * t * t * t
                : 1f - Mathf.Pow(-2f * t + 2f, 3f) * 0.5f;

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseInQuart(float t)
            => t * t * t * t;

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseOutQuart(float t)
            => 1f - Mathf.Pow(1f - t, 4f);

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseInOutQuart(float t)
            => t < 0.5f
                ? 8f * t * t * t * t
                : 1f - Mathf.Pow(-2f * t + 2, 4f) * 0.5f;

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseInQuint(float t)
            => t * t * t * t * t;

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseOutQuint(float t)
            => 1f - Mathf.Pow(1f - t, 5f);

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseInOutQuint(float t)
            => t < 0.5f
                ? 16f * t * t * t * t * t
                : 1f - Mathf.Pow(-2f * t + 2f, 5f) * 0.5f;

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseInExpo(float t)
            => t == 0f
                ? 0f
                : Mathf.Pow(2f, 10f * t - 10f);

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseOutExpo(float t)
            => t == 1f
                ? 1f
                : 1f - Mathf.Pow(2f, -10f * t);

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseInOutExpo(float t)
            => t == 0f
                ? 0f
                : t == 1f
                ? 1f
                : t < 0.5f ? Mathf.Pow(2f, 20f * t - 10f) * 0.5f
                : (2f - Mathf.Pow(2f, -20f * t + 10f)) * 0.5f;

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseInCirc(float t)
            => 1f - Mathf.Sqrt(1f - Mathf.Pow(t, 2f));

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseOutCirc(float t)
            => Mathf.Sqrt(1f - Mathf.Pow(t - 1f, 2f));

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseInOutCirc(float t)
            => t < 0.5f
                ? (1f - Mathf.Sqrt(1f - Mathf.Pow(2f * t, 2f))) * 0.5f
                : (Mathf.Sqrt(1f - Mathf.Pow(-2f * t + 2f, 2f)) + 1f) * 0.5f;

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseInBack(float t)
            => C3 * t * t * t - C1 * t * t;

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseOutBack(float t)
            => 1f + C3 * Mathf.Pow(t - 1f, 3f) + C1 * Mathf.Pow(t - 1f, 2f);

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseInOutBack(float t)
            => t < 0.5f
                ? (Mathf.Pow(2f * t, 2f) * ((C2 + 1f) * 2f * t - C2)) * 0.5f
                : (Mathf.Pow(2f * t - 2f, 2f) * ((C2 + 1f) * (t * 2f - 2f) + C2) + 2f) * 0.5f;

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseInElastic(float t)
            => t == 0f
                ? 0f
                : t == 1f
                ? 1f
                : -Mathf.Pow(2f, 10f * t - 10f) * Mathf.Sin((t * 10f - 10.75f) * C4);

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseOutElastic(float t)
            => t == 0f
                ? 0f
                : t == 1f
                ? 1f
                : Mathf.Pow(2f, -10f * t) * Mathf.Sin((t * 10f - 0.75f) * C4) + 1f;

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseInOutElastic(float t)
            => t == 0f
                ? 0f
                : t == 1f
                ? 1f
                : t < 0.5f
                ? -(Mathf.Pow(2f, 20f * t - 10f) * Mathf.Sin((20f * t - 11.125f) * C5)) * 0.5f
                : (Mathf.Pow(2f, -20f * t + 10f) * Mathf.Sin((20f * t - 11.125f) * C5)) * 0.5f + 1f;

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseInBounce(float t)
            => 1f - EaseOutBounce(1f - t);

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseOutBounce(float t)
        {
            if (t < 1f / D1)
                return N1 * t * t;
            else if (t < 2f / D1)
                return N1 * (t -= 1.5f / D1) * t + 0.75f;
            else if (t < 2.5f / D1)
                return N1 * (t -= 2.25f / D1) * t + 0.9375f;
            else
                return N1 * (t -= 2.625f / D1) * t + 0.984375f;
        }

        /// <param name="t">Normalized time value between 0 and 1 inclusive</param>
        /// <returns>Returns y-value at x=t.</returns>
        public static float EaseInOutBounce(float t)
            => t < 0.5f
                ? (1f - EaseOutBounce(1f - 2f * t)) * 0.5f
                : (1f + EaseOutBounce(2f * t - 1f)) * 0.5f;
    }
}
