using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasingTest : MonoBehaviour
{

    [SerializeField]
    private EasingType type;

    private GameObject ball;

    private float width = 1.45f;
    private float height = 0.725f;

    private float startX = 0.0f;
    private float startY = 0.0f;

    private float endX = 1.45f;
    private float endY = 0.725f;

    private float time = 0.0f;
    private float startWaitTime = 0.5f;
    private float endWaitTime = 0.5f;
    private float easingTime = 1.0f;

	void Start ()
    {
        ball = transform.Find("ball").gameObject;

        startX = transform.position.x;
        startY = transform.position.y;

        endX = transform.position.x + width;
        endY = transform.position.y + height;
    }

    void Update()
    {
        if (0 < time && time <= easingTime)
        {
            Move();
        }
        else if ( easingTime < time && time <= easingTime + easingTime + endWaitTime)
        {
            ball.transform.position = new Vector3(endX,endY,0);
        }
        else if (easingTime + endWaitTime < time)
        {
            time = -startWaitTime;
            ball.transform.localPosition = new Vector3();
        }

        time += Time.deltaTime;
    }

    private void Move()
    {
        float xx = (endX - startX) * time / easingTime;
        float yy = 0.0f;

        switch (type)
        {
            case EasingType.Constant:
                yy = endY;
                break;
            case EasingType.QuadIn:
                yy = Easing.QuadIn(time, easingTime, startY, endY);
                break;
            case EasingType.QuadOut:
                yy = Easing.QuadOut(time, easingTime, startY, endY);
                break;
            case EasingType.QuadInOut:
                yy = Easing.QuadInOut(time, easingTime, startY, endY);
                break;
            case EasingType.CubicIn:
                yy = Easing.CubicIn(time, easingTime, startY, endY);
                break;
            case EasingType.CubicOut:
                yy = Easing.CubicOut(time, easingTime, startY, endY);
                break;
            case EasingType.CubicInOut:
                yy = Easing.CubicInOut(time, easingTime, startY, endY);
                break;
            case EasingType.QuartIn:
                yy = Easing.QuartIn(time, easingTime, startY, endY);
                break;
            case EasingType.QuartOut:
                yy = Easing.QuartOut(time, easingTime, startY, endY);
                break;
            case EasingType.QuartInOut:
                yy = Easing.QuartInOut(time, easingTime, startY, endY);
                break;
            case EasingType.QuintIn:
                yy = Easing.QuintIn(time, easingTime, startY, endY);
                break;
            case EasingType.QuintOut:
                yy = Easing.QuintOut(time, easingTime, startY, endY);
                break;
            case EasingType.QuintInOut:
                yy = Easing.QuintInOut(time, easingTime, startY, endY);
                break;
            case EasingType.SineIn:
                yy = Easing.SineIn(time, easingTime, startY, endY);
                break;
            case EasingType.SineOut:
                yy = Easing.SineOut(time, easingTime, startY, endY);
                break;
            case EasingType.SineInOut:
                yy = Easing.SineInOut(time, easingTime, startY, endY);
                break;
            case EasingType.ExpIn:
                yy = Easing.ExpIn(time, easingTime, startY, endY);
                break;
            case EasingType.ExpOut:
                yy = Easing.ExpOut(time, easingTime, startY, endY);
                break;
            case EasingType.ExpInOut:
                yy = Easing.ExpInOut(time, easingTime, startY, endY);
                break;
            case EasingType.CircIn:
                yy = Easing.CircIn(time, easingTime, startY, endY);
                break;
            case EasingType.CircOut:
                yy = Easing.CircOut(time, easingTime, startY, endY);
                break;
            case EasingType.CircInOut:
                yy = Easing.CircInOut(time, easingTime, startY, endY);
                break;
            case EasingType.ElasticIn:
                yy = Easing.ElasticIn(time, easingTime, startY, endY);
                break;
            case EasingType.ElasticOut:
                yy = Easing.ElasticOut(time, easingTime, startY, endY);
                break;
            case EasingType.ElasticInOut:
                yy = Easing.ElasticInOut(time, easingTime, startY, endY);
                break;
            case EasingType.BackIn:
                yy = Easing.BackIn(time, easingTime, startY, endY, 1.7f);
                break;
            case EasingType.BackOut:
                yy = Easing.BackOut(time, easingTime, startY, endY, 1.7f);
                break;
            case EasingType.BackInOut:
                yy = Easing.BackInOut(time, easingTime, startY, endY, 1.7f);
                break;
            case EasingType.BounceIn:
                yy = Easing.BounceIn(time, easingTime, startY, endY);
                break;
            case EasingType.BounceOut:
                yy = Easing.BounceOut(time, easingTime, startY, endY);
                break;
            case EasingType.BounceInOut:
                yy = Easing.BounceInOut(time, easingTime, startY, endY);
                break;
            case EasingType.Linear:
                yy = Easing.Linear(time, easingTime, startY, endY);
                break;
        }

        if(float.IsNaN(yy)) yy = 1;

        ball.transform.position = new Vector3(startX + xx, yy, 0);
    }
}
