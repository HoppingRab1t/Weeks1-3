using JetBrains.Annotations;
using UnityEngine;

public class LensFlare : MonoBehaviour
    
{
    
    public AnimationCurve curve;
    float time = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        time = Random.Range(1, 10);
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
