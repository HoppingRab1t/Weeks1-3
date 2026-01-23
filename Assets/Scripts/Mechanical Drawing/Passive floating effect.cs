using System.Security.Cryptography;
using UnityEngine;

public class Passivefloatingeffect : MonoBehaviour
{
    public AnimationCurve curve;
    float time = Random.Range(1, 10);
    float multi = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += 0.2f * Time.deltaTime;

        if (time > 1)
        {
            time = 0;
        }

        Vector2 pos = transform.position;
        pos.y = curve.Evaluate(time);



        transform.position = pos * multi;
    }
}
