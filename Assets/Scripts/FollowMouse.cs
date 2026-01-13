using UnityEngine;
using UnityEngine.InputSystem;

public class SecondScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        transform.position = newPos;




    }
}
