using JetBrains.Annotations;
using System.Net.Sockets;
using UnityEngine;

public class OtherCarMovement : MonoBehaviour
{
    public Vector2 start;
    public Vector2 end;
    public AnimationCurve curves;
    float time = 0;
    float delay = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //sets the random positon at the start
        start.x = Random.Range(-15f, 15f);
        end.x = Random.Range(-15f, 15f);

        start.y = Random.Range(-8f, 8f);
        end.y = Random.Range(-8f, 8f);
    }

    // Update is called once per frame
    void Update()
    {
        //delay timer that slowly counts to zero
        delay -= 1 * Time.deltaTime;

        //if the delay is below zero the timer will start
        if (delay <= 0)
        {
            time += 0.1f * Time.deltaTime;

        }
        
        if (time > 1)
        {            
            
            
            //sets the end postion to the start and resets where it should go next
            start = transform.position;
            end.x = Random.Range(-15f, 15f);
            end.y = Random.Range(-8f, 8f);


            time = 0;
            delay = Random.Range(5, 10);


        }
        //note:  lerp has a set paramter between 0 and 1, anyhting above could result in the object to seemingly jump to the end
        transform.position = Vector2.Lerp(start,end,curves.Evaluate(time));

    }
}
