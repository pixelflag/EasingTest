using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Easing2DTest : MonoBehaviour
{
    [SerializeField]
    private EasingType type;

    [SerializeField]
    private GameObject target;

    private GameObject ball;

    private Vector2 startPos;

    private Vector2 endPos;

    private float time = 0.0f;
    private float startWaitTime = 0.5f;
    private float endWaitTime = 0.5f;
    private float easingTime = 2.0f;

    void Start()
    {
        ball = transform.Find("ball").gameObject;
        startPos = ball.transform.position;
        endPos = target.transform.position;
    }

    void Update()
    {
        if (0 < time && time <= easingTime)
        {
            Move();
        }
        else if (easingTime < time && time <= easingTime + easingTime + endWaitTime)
        {
            ball.transform.position = endPos;
        }
        else if (easingTime + endWaitTime < time)
        {
            time = -startWaitTime;
            ball.transform.position = startPos;
        }

        time += Time.deltaTime;
    }

    private void Move()
    {
        Vector2 pos = new Vector2();

        switch (type)
        {
            case EasingType.Constant:
                pos = endPos;
                break;
            case EasingType.QuadIn:
                pos = Easing2D.QuadIn(time, easingTime, startPos, endPos);
                break;
            case EasingType.QuadOut:
                pos = Easing2D.QuadOut(time, easingTime, startPos, endPos);
                break;
            case EasingType.QuadInOut:
                pos = Easing2D.QuadInOut(time, easingTime, startPos, endPos);
                break;
            case EasingType.CubicIn:
                pos = Easing2D.CubicIn(time, easingTime, startPos, endPos);
                break;
            case EasingType.CubicOut:
                pos = Easing2D.CubicOut(time, easingTime, startPos, endPos);
                break;
            case EasingType.CubicInOut:
                pos = Easing2D.CubicInOut(time, easingTime, startPos, endPos);
                break;
            case EasingType.QuartIn:
                pos = Easing2D.QuartIn(time, easingTime, startPos, endPos);
                break;
            case EasingType.QuartOut:
                pos = Easing2D.QuartOut(time, easingTime, startPos, endPos);
                break;
            case EasingType.QuartInOut:
                pos = Easing2D.QuartInOut(time, easingTime, startPos, endPos);
                break;
            case EasingType.QuintIn:
                pos = Easing2D.QuintIn(time, easingTime, startPos, endPos);
                break;
            case EasingType.QuintOut:
                pos = Easing2D.QuintOut(time, easingTime, startPos, endPos);
                break;
            case EasingType.QuintInOut:
                pos = Easing2D.QuintInOut(time, easingTime, startPos, endPos);
                break;
            case EasingType.SineIn:
                pos = Easing2D.SineIn(time, easingTime, startPos, endPos);
                break;
            case EasingType.SineOut:
                pos = Easing2D.SineOut(time, easingTime, startPos, endPos);
                break;
            case EasingType.SineInOut:
                pos = Easing2D.SineInOut(time, easingTime, startPos, endPos);
                break;
            case EasingType.ExpIn:
                pos = Easing2D.ExpIn(time, easingTime, startPos, endPos);
                break;
            case EasingType.ExpOut:
                pos = Easing2D.ExpOut(time, easingTime, startPos, endPos);
                break;
            case EasingType.ExpInOut:
                pos = Easing2D.ExpInOut(time, easingTime, startPos, endPos);
                break;
            case EasingType.CircIn:
                pos = Easing2D.CircIn(time, easingTime, startPos, endPos);
                break;
            case EasingType.CircOut:
                pos = Easing2D.CircOut(time, easingTime, startPos, endPos);
                break;
            case EasingType.CircInOut:
                pos = Easing2D.CircInOut(time, easingTime, startPos, endPos);
                break;
            case EasingType.ElasticIn:
                pos = Easing2D.ElasticIn(time, easingTime, startPos, endPos);
                break;
            case EasingType.ElasticOut:
                pos = Easing2D.ElasticOut(time, easingTime, startPos, endPos);
                break;
            case EasingType.ElasticInOut:
                pos = Easing2D.ElasticInOut(time, easingTime, startPos, endPos);
                break;
            case EasingType.BackIn:
                pos = Easing2D.BackIn(time, easingTime, startPos, endPos, 1.7f);
                break;
            case EasingType.BackOut:
                pos = Easing2D.BackOut(time, easingTime, startPos, endPos, 1.7f);
                break;
            case EasingType.BackInOut:
                pos = Easing2D.BackInOut(time, easingTime, startPos, endPos, 1.7f);
                break;
            case EasingType.BounceIn:
                pos = Easing2D.BounceIn(time, easingTime, startPos, endPos);
                break;
            case EasingType.BounceOut:
                pos = Easing2D.BounceOut(time, easingTime, startPos, endPos);
                break;
            case EasingType.BounceInOut:
                pos = Easing2D.BounceInOut(time, easingTime, startPos, endPos);
                break;
            case EasingType.Linear:
                pos = Easing2D.Linear(time, easingTime, startPos, endPos);
                break;
        }

        ball.transform.position = pos;
    }
}
