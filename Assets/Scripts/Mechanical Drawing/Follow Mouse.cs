using UnityEngine;
using UnityEngine.InputSystem;

public class FollowMouse : MonoBehaviour
{
    public int interval;
    public AnimationCurve Movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPos = transform.position;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        currentPos.x += (mousePos.x - currentPos.x) / interval;
        currentPos.y += (mousePos.y - currentPos.y) / interval;

        transform.position = currentPos * Time.deltaTime;

    }
}
