using UnityEngine;
using UnityEngine.InputSystem;
public class MouseOverScript : MonoBehaviour
{
    public bool MouseOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        float distance = Vector2.Distance(transform.position, mousePos);

        if (distance < 5)
        {
            MouseOver = true;
        } else
        {
            MouseOver = false;
        }
    }
}
