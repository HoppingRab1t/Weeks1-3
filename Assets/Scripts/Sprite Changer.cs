using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        
        //if (Keyboard.current.wKey.isPressed == true)
        //{
        //    pickARandomColour();
        //}
        if ( spriteRenderer.bounds.Contains(pos))
        {
            pickARandomColour();
        }
        else
        {
            spriteRenderer.color = Color.white;
        }
    }
    void pickARandomColour()
    {
        //spriteRenderer.color = Random.ColorHSV();
        spriteRenderer.color = col;
    }
}
