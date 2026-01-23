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


        //does the sine wave (I don't think I could use animation curve effectivly since it sets the variable and to prevent it I must associate it to another variable, but I might as well do a sine wave and demonstrate mathf.sin)
        Vector2 pos = transform.position;
        multi = Mathf.Sin(time)*amp;
        pos.y += multi;

        
        transform.position = pos ;
    }
}
