using System;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class RollOver : MonoBehaviour
{
    public AnimationCurve curve;
    public bool mouseOver;
    public float time;
    public float time2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        float distance = Vector2.Distance(transform.position, mousePos);

        if (distance < transform.localScale.x)
        {
            time += Time.deltaTime;
            time2 += Time.deltaTime;

        }
        else
        {
            time = 0;
        }
        if (time2>1)
        {
            time2 = 0;
        }
        transform.localScale = Vector3.one * (1 + time);
        transform.position = new Vector2(0,1 * curve.Evaluate(time2));


    }
}
