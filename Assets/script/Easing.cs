using UnityEngine;

public class Easing
{
    public static float QuadIn(float t, float totaltime, float min, float max)
    {
        max -= min;
        t /= totaltime;
        return max * t * t + min;
    }

    public static float QuadOut(float t, float totaltime, float min, float max)
    {
        max -= min;
        t /= totaltime;
        return -max * t * (t - 2) + min;
    }

    public static float QuadInOut(float t, float totaltime, float min, float max)
    {
        max -= min;
        t /= totaltime / 2;
        if (t < 1) return max / 2 * t * t + min;

        t = t-1;
        return -max/ 2 * (t * (t - 2) - 1) + min;
    }

    public static float CubicIn(float t, float totaltime, float min, float max)
    {
        max -= min;
        t /= totaltime;
        return max * t * t * t + min;
    }

    public static float CubicOut(float t, float totaltime, float min, float max)
    {
        max -= min;
        t = t / totaltime - 1;
        return max * (t * t * t + 1) + min;
    }

    public static float CubicInOut(float t, float totaltime, float min, float max)
    {
        max -= min;
        t /= totaltime/2;
        if (t < 1) return max / 2 * t * t * t + min;

        t = t - 2;
        return max / 2 * (t * t * t + 2) + min;
    }

    public static float QuartIn(float t, float totaltime, float min, float max)
    {
        max -= min;
        t /= totaltime;
        return max * t * t * t * t + min;
    }

    public static float QuartOut(float t, float totaltime, float min, float max)
    {
        max -= min;
        t = t / totaltime - 1;
        return -max * (t * t * t * t - 1) + min;
    }

    public static float QuartInOut(float t, float totaltime, float min, float max)
    {
        max -= min;
        t /= totaltime/ 2;
        if (t < 1) return max / 2 * t * t * t * t + min;

        t = t - 2;
        return -max / 2 * (t * t * t * t - 2) + min;
    }

    public static float QuintIn(float t, float totaltime, float min, float max)
    {
        max -= min;
        t /= totaltime;
        return max * t * t * t * t * t + min;
    }

    public static float QuintOut(float t, float totaltime, float min, float max)
    {
        max -= min;
        t = t / totaltime - 1;
        return max * (t * t * t * t * t + 1) + min;
    }

    public static float QuintInOut(float t, float totaltime, float min, float max)
    {
        max -= min;
        t /= totaltime / 2;
        if (t < 1) return max / 2 * t * t * t * t * t + min;

        t = t - 2;
        return max / 2 * (t * t * t * t * t + 2) + min;
    }

    public static float SineIn(float t, float totaltime, float min, float max)
    {
        max -= min;
        return -max * Mathf.Cos(t * (Mathf.PI * 90 / 180) / totaltime) + max + min;
    }

    public static float SineOut(float t, float totaltime, float min, float max)
    {
        max -= min;
        return max * Mathf.Sin(t * (Mathf.PI * 90 / 180) / totaltime) + min;
    }

    public static float SineInOut(float t, float totaltime, float min, float max)
    {
        max -= min;
        return -max / 2 * (Mathf.Cos(t * Mathf.PI / totaltime) - 1) + min;
    }

    public static float ExpIn(float t, float totaltime, float min, float max)
    {
        max -= min;
        return t == 0.0 ? min : max * Mathf.Pow(2, 10 * (t / totaltime - 1)) + min;
    }

    public static float ExpOut(float t, float totaltime, float min, float max)
    {
        max -= min;
        return t == totaltime ? max + min : max * (-Mathf.Pow(2, -10 * t / totaltime) + 1) + min;
    }

    public static float ExpInOut(float t, float totaltime, float min, float max)
    {
        if (t == 0.0f) return min;
        if (t == totaltime) return max;
        max -= min;
        t /= totaltime / 2;

        if (t < 1) return max / 2 * Mathf.Pow(2, 10 * (t - 1)) + min;

        t = t-1;
        return max / 2 * (-Mathf.Pow(2, -10 * t) + 2) + min;

    }

    public static float CircIn(float t, float totaltime, float min, float max)
    {
        max -= min;
        t /= totaltime;
        return -max * (Mathf.Sqrt(1 - t * t) - 1) + min;
    }

    public static float CircOut(float t, float totaltime, float min, float max)
    {
        max -= min;
        t = t / totaltime - 1;
        return max * Mathf.Sqrt(1 - t * t) + min;
    }

    public static float CircInOut(float t, float totaltime, float min, float max)
    {
        max -= min;
        t /= totaltime / 2;
        if (t < 1) return -max / 2 * (Mathf.Sqrt(1 - t * t) - 1) + min;

        t = t - 2;
        return max / 2 * (Mathf.Sqrt(1 - t * t) + 1) + min;
    }

    public static float ElasticIn(float t, float totaltime, float min, float max)
    {
        max -= min;
        t /= totaltime;

        float s = 1.70158f;
        float p = totaltime * 0.3f;
        float a = max;

        if (t == 0) return min;
        if (t == 1) return min + max;

        if (a < Mathf.Abs(max))
        {
            a = max;
            s = p / 4;
        }
        else
        {
            s = p / (2 * Mathf.PI) * Mathf.Asin(max / a);
        }

        t = t - 1;
        return -(a * Mathf.Pow(2, 10 * t) * Mathf.Sin((t * totaltime - s) * (2 * Mathf.PI) / p)) + min;
    }

    public static float ElasticOut(float t, float totaltime, float min, float max)
    {
        max -= min;
        t /= totaltime;

        float s = 1.70158f;
        float p = totaltime * 0.3f; ;
        float a = max;

        if (t == 0) return min;
        if (t == 1) return min + max;

        if (a < Mathf.Abs(max))
        {
            a = max;
            s = p / 4;
        }
        else
        {
            s = p / (2 * Mathf.PI) * Mathf.Asin(max / a);
        }

        return a * Mathf.Pow(2, -10 * t) * Mathf.Sin((t * totaltime - s) * (2 * Mathf.PI) / p) + max + min;
    }

	public static float ElasticInOut(float t, float totaltime, float min, float max)
    {
        max -= min;
        t /= totaltime / 2;

        float s = 1.70158f;
        float p = totaltime * (0.3f * 1.5f);
        float a = max;

        if (t == 0) return min;
        if (t == 2) return min + max;

        if (a < Mathf.Abs(max))
        {
            a = max;
            s = p / 4;
        }
        else
        {
            s = p / (2 * Mathf.PI) * Mathf.Asin(max / a);
        }

        if (t < 1)
        {
            return -0.5f * (a * Mathf.Pow(2, 10 * (t -= 1)) * Mathf.Sin((t * totaltime - s) * (2 * Mathf.PI) / p)) + min;
        }

        t = t - 1;
        return a * Mathf.Pow(2, -10 * t) * Mathf.Sin((t * totaltime - s) * (2 * Mathf.PI) / p) * 0.5f + max + min;
    }

    public static float BackIn(float t, float totaltime, float min, float max, float s)
    {
        max -= min;
        t /= totaltime;
        return max * t * t * ((s + 1) * t - s) + min;
    }

    public static float BackOut(float t, float totaltime, float min, float max, float s)
    {
        max -= min;
        t = t / totaltime - 1;
        return max * (t * t * ((s + 1) * t + s) + 1) + min;
    }

    public static float BackInOut(float t, float totaltime, float min, float max, float s)
    {
        max -= min;
        s *= 1.525f;
        t /= totaltime/2;
        if (t < 1) return max/2 * (t * t * ((s + 1) * t - s)) + min;

        t = t - 2;
        return max / 2 * (t * t * ((s + 1) * t + s) + 2) + min;
    }

    public static float BounceIn(float t, float totaltime, float min, float max)
    {
        max -= min;
        return max - BounceOut(totaltime - t, totaltime, 0, max) + min;
    }

    public static float BounceOut(float t, float totaltime, float min, float max)
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

    public static float BounceInOut(float t, float totaltime, float min, float max)
    {
        if (t < totaltime / 2)
        {
            return BounceIn(t * 2, totaltime, 0, max - min) * 0.5f + min;
        }
        else
        {
            return BounceOut(t * 2 - totaltime, totaltime, 0, max - min) * 0.5f + min + (max - min) * 0.5f;
        }
    }

    public static float Linear(float t, float totaltime, float min, float max)
    {
        return (max - min) * t / totaltime + min;
    }

}