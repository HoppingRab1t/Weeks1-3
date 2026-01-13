using UnityEngine;
using UnityEngine.UIElements;

public class Bouncingball : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float time;
    public AnimationCurve curve;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y = curve.Evaluate(time);
        time += Time.deltaTime;
        if (time > 1)
        {
            time = 0;
        }
        transform.position = pos;


    }
}
