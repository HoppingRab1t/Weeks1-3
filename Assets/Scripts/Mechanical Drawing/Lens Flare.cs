using JetBrains.Annotations;
using UnityEngine;

public class LensFlare : MonoBehaviour
    
{
    
    public AnimationCurve curve;
    float time = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //sets a random time delay so that the flares won't activate at the same time.
        time = Random.Range(1, 10);
    }

    // Update is called once per frame
    void Update()
       
    {
        time += 1 * Time.deltaTime;

        //reset timer when 0
        if (time > 10)
        {
            time = 0;
        }

        //sets the variable to the scale and change it 
        Vector2 Scale = transform.localScale;
        Scale.x = curve.Evaluate(time) ;
        Scale.y = curve.Evaluate(time) ;
        //uses an animation curve to animate the bounce.

        //changes the scale
        transform.localScale = Scale;
    }
}
