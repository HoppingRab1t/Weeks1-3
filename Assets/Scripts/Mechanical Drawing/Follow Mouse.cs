using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class FollowMouse : MonoBehaviour
{
    public float interval = 0.5f;
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
        
        //this is where the function changes the variable 
        //this makes the flying car to slowly approach the mouse.
        currentPos.x += (mousePos.x - currentPos.x) / interval * Time.deltaTime;
        currentPos.y += (mousePos.y - currentPos.y) / interval * Time.deltaTime;


        //set the positon
        transform.position = currentPos ;

    }
}
