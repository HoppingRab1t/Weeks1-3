using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class FollowMouse : MonoBehaviour
{
    public float interval = 0.5f;
    public float time = 0;
    public float slopeAmount = 1;
    //public Vector2 mousePos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPos = transform.position;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        
        //time += 1 * Time.deltaTime;
        //float wave = Mathf.Asin(time) * slopeAmount + 1;

        //currentPos.y -= wave;

        currentPos.x += (mousePos.x - currentPos.x) / interval * Time.deltaTime;
        currentPos.y += (mousePos.y - currentPos.y) / interval * Time.deltaTime;

        //currentPos.y += wave;


        transform.position = currentPos ;

    }
}
