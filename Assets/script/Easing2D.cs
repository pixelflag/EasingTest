using UnityEngine;

public class Easing2D
{
    public static Vector2 QuadIn(float t, float totaltime, Vector2 min, Vector2 max)
    {
        max -= min;
        t /= totaltime;
        return max * t * t + min;
    }

    public static Vector2 QuadOut(float t, float totaltime, Vector2 min, Vector2 max)
    {
        max -= min;
        t /= totaltime;
        return -max * t * (t - 2) + min;
    }

    public static Vector2 QuadInOut(float t, float totaltime, Vector2 min, Vector2 max)
    {
        max -= min;
        t /= totaltime / 2;
        if (t < 1) return max / 2 * t * t + min;

        t = t-1;
        return -max/ 2 * (t * (t - 2) - 1) + min;
    }

    public static Vector2 CubicIn(float t, float totaltime, Vector2 min, Vector2 max)
    {
        max -= min;
        t /= totaltime;
        return max * t * t * t + min;
    }

    public static Vector2 CubicOut(float t, float totaltime, Vector2 min, Vector2 max)
    {
        max -= min;
        t = t / totaltime - 1;
        return max * (t * t * t + 1) + min;
    }

    public static Vector2 CubicInOut(float t, float totaltime, Vector2 min, Vector2 max)
    {
        max -= min;
        t /= totaltime/2;
        if (t < 1) return max / 2 * t * t * t + min;

        t = t - 2;
        return max / 2 * (t * t * t + 2) + min;
    }

    public static Vector2 QuartIn(float t, float totaltime, Vector2 min, Vector2 max)
    {
        max -= min;
        t /= totaltime;
        return max * t * t * t * t + min;
    }

    public static Vector2 QuartOut(float t, float totaltime, Vector2 min, Vector2 max)
    {
        max -= min;
        t = t / totaltime - 1;
        return -max * (t * t * t * t - 1) + min;
    }

    public static Vector2 QuartInOut(float t, float totaltime, Vector2 min, Vector2 max)
    {
        max -= min;
        t /= totaltime/ 2;
        if (t < 1) return max / 2 * t * t * t * t + min;

        t = t - 2;
        return -max / 2 * (t * t * t * t - 2) + min;
    }

    public static Vector2 QuintIn(float t, float totaltime, Vector2 min, Vector2 max)
    {
        max -= min;
        t /= totaltime;
        return max * t * t * t * t * t + min;
    }

    public static Vector2 QuintOut(float t, float totaltime, Vector2 min, Vector2 max)
    {
        max -= min;
        t = t / totaltime - 1;
        return max * (t * t * t * t * t + 1) + min;
    }

    public static Vector2 QuintInOut(float t, float totaltime, Vector2 min, Vector2 max)
    {
        max -= min;
        t /= totaltime / 2;
        if (t < 1) return max / 2 * t * t * t * t * t + min;

        t = t - 2;
        return max / 2 * (t * t * t * t * t + 2) + min;
    }

    public static Vector2 SineIn(float t, float totaltime, Vector2 min, Vector2 max)
    {
        max -= min;
        return -max * Mathf.Cos(t * (Mathf.PI * 90 / 180) / totaltime) + max + min;
    }

    public static Vector2 SineOut(float t, float totaltime, Vector2 min, Vector2 max)
    {
        max -= min;
        return max * Mathf.Sin(t * (Mathf.PI * 90 / 180) / totaltime) + min;
    }

    public static Vector2 SineInOut(float t, float totaltime, Vector2 min, Vector2 max)
    {
        max -= min;
        return -max / 2 * (Mathf.Cos(t * Mathf.PI / totaltime) - 1) + min;
    }

    public static Vector2 ExpIn(float t, float totaltime, Vector2 min, Vector2 max)
    {
        max -= min;
        return t == 0.0 ? min : max * Mathf.Pow(2, 10 * (t / totaltime - 1)) + min;
    }

    public static Vector2 ExpOut(float t, float totaltime, Vector2 min, Vector2 max)
    {
        max -= min;
        return t == totaltime ? max + min : max * (-Mathf.Pow(2, -10 * t / totaltime) + 1) + min;
    }

    public static Vector2 ExpInOut(float t, float totaltime, Vector2 min, Vector2 max)
    {
        if (t == 0.0f) return min;
        if (t == totaltime) return max;
        max -= min;
        t /= totaltime / 2;

        if (t < 1) return max / 2 * Mathf.Pow(2, 10 * (t - 1)) + min;

        t = t-1;
        return max / 2 * (-Mathf.Pow(2, -10 * t) + 2) + min;

    }

    public static Vector2 CircIn(float t, float totaltime, Vector2 min, Vector2 max)
    {
        max -= min;
        t /= totaltime;
        return -max * (Mathf.Sqrt(1 - t * t) - 1) + min;
    }

    public static Vector2 CircOut(float t, float totaltime, Vector2 min, Vector2 max)
    {
        max -= min;
        t = t / totaltime - 1;
        return max * Mathf.Sqrt(1 - t * t) + min;
    }

    public static Vector2 CircInOut(float t, float totaltime, Vector2 min, Vector2 max)
    {
        max -= min;
        t /= totaltime / 2;
        if (t < 1) return -max / 2 * (Mathf.Sqrt(1 - t * t) - 1) + min;

        t = t - 2;
        return max / 2 * (Mathf.Sqrt(1 - t * t) + 1) + min;
    }

    public static Vector2 ElasticIn(float t, float totaltime, Vector2 min, Vector2 max)
    {
        // 無理でした
        return max;
    }

    public static Vector2 ElasticOut(float t, float totaltime, Vector2 min, Vector2 max)
    {
        // 無理でした
        return max;
    }

    public static Vector2 ElasticInOut(float t, float totaltime, Vector2 min, Vector2 max)
    {
        // 無理でした
        return max;
    }

    public static Vector2 BackIn(float t, float totaltime, Vector2 min, Vector2 max, float s)
    {
        max -= min;
        t /= totaltime;
        return max * t * t * ((s + 1) * t - s) + min;
    }

    public static Vector2 BackOut(float t, float totaltime, Vector2 min, Vector2 max, float s)
    {
        max -= min;
        t = t / totaltime - 1;
        return max * (t * t * ((s + 1) * t + s) + 1) + min;
    }

    public static Vector2 BackInOut(float t, float totaltime, Vector2 min, Vector2 max, float s)
    {
        max -= min;
        s *= 1.525f;
        t /= totaltime/2;
        if (t < 1) return max/2 * (t * t * ((s + 1) * t - s)) + min;

        t = t - 2;
        return max / 2 * (t * t * ((s + 1) * t + s) + 2) + min;
    }

    public static Vector2 BounceIn(float t, float totaltime, Vector2 min, Vector2 max)
    {
        max -= min;
        return max - BounceOut(totaltime - t, totaltime, new Vector2(), max) + min;
    }

    public static Vector2 BounceOut(float t, float totaltime, Vector2 min, Vector2 max)
    {
        max -= min;
        t /= totaltime;

        if (t < 1.0f / 2.75f)
        {
            return max * (7.5625f * t * t) + min;
        }
        else if (t < 2.0f / 2.75f)
        {
            t -= 1.5f / 2.75f;
            return max * (7.5625f * t * t + 0.75f) + min;
        }
        else if (t < 2.5f / 2.75f)
        {
            t -= 2.25f / 2.75f;
            return max * (7.5625f * t * t + 0.9375f) + min;
        }
        else
        {
            t -= 2.625f / 2.75f;
            return max * (7.5625f * t * t + 0.984375f) + min;
        }
    }

    public static Vector2 BounceInOut(float t, float totaltime, Vector2 min, Vector2 max)
    {
        if (t < totaltime / 2)
        {
            return BounceIn(t * 2, totaltime, new Vector2(), max - min) * 0.5f + min;
        }
        else
        {
            return BounceOut(t * 2 - totaltime, totaltime, new Vector2(), max - min) * 0.5f + min + (max - min) * 0.5f;
        }
    }

    public static Vector2 Linear(float t, float totaltime, Vector2 min, Vector2 max)
    {
        return (max - min) * t / totaltime + min;
    }

}