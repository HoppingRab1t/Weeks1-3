using System.Security.Cryptography;
using UnityEngine;

public class Passivefloatingeffect : MonoBehaviour
{
    float time;
    public float multi = 1;
    public float amp = 0.01f;
    //float poop = mathf.sin(2);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //sets the random time or x value for the sin wave
        time  = Random.Range(-100, 100);
    }

    // Update is called once per frame
    void Update()
    {
        time += 1 * Time.deltaTime;

        //if (time > 4)
        //{
        //    time = -4;
        //}

        //does the sine wave 
        Vector2 pos = transform.position;
        multi = Mathf.Sin(time)*amp;
        pos.y += multi;

        
        transform.position = pos ;
    }
}
