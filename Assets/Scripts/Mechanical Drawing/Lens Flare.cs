using JetBrains.Annotations;
using UnityEngine;

public class LensFlare : MonoBehaviour
    
{
    
    public AnimationCurve curve;
    float time = Random.Range(1,10);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
       
    {
        time += 1 * Time.deltaTime;

        if (time > 10)
        {
            time = 0;
        }

        Vector2 Scale = transform.localScale;
        Scale.x = curve.Evaluate(time) ;
        Scale.y = curve.Evaluate(time) ;



        transform.localScale = Scale;
    }
}
