using Unity.Multiplayer.Center.Common;
using UnityEngine;
using UnityEngine.InputSystem;
public class BackgroundCarMovement : MonoBehaviour
{
    public Vector2 pos;
    public Vector2 pos1;
    public float speed = 1;
    public int direction = 1;

    Vector2 bottomLeft;
    Vector2 topRight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
         topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    // Update is called once per frame
    void Update()
    {
        //sets the position for the variable 
        pos = transform.position;
        pos.x += speed *direction * Time.deltaTime;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        //depending on the direction there will be spacific conditionals that will be activated incase they conflict with each other.
        if (direction == 1)
        {
            if (screenPos.x > Screen.width)
            {           
                pos.x = bottomLeft.x;
            }

        }
        else
        {
            if (screenPos.x < 0)
            {
                pos.x = topRight.x;
            }
        }

        //sets the position.
        transform.position = pos;
    }
}
