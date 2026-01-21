using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class TankMovement : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        Vector2 pos = transform.position;
        if (Keyboard.current.aKey.isPressed == true)
        {
            pos.x -= 10 * 1* Time.deltaTime;

            if (screenPos.x < pos.x)
            {
                pos.x += 10 * 1 * Time.deltaTime;
            }
        }


        if (Keyboard.current.dKey.isPressed == true)
        {
            pos.x += 10 *1*Time.deltaTime;
            if (screenPos.x > Screen.width)
            {
                pos.x -= 10 * 1 * Time.deltaTime;
            }
        }

        
       

        transform.position = pos;   

    }
}
