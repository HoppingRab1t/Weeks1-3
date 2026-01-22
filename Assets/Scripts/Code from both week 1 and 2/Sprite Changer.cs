using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public List<Sprite> berrel0;
    
    public int randomnum;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        if (Keyboard.current.wKey.isPressed == true)
        {
            pickARandomSprite();
        }

        if ( spriteRenderer.bounds.Contains(pos))
        {
            pickARandomColour();

        }
        else
        {
            spriteRenderer.color = Color.white;
        }

        if (Mouse.current.leftButton.wasPressedThisFrame && berrel0.Count>0)
        {
            berrel0.RemoveAt(0);
        } else
        {
            //Debug.Log("nothing to remove");
        }
    }
    void pickARandomColour()
    {
        //spriteRenderer.color = Random.ColorHSV();
        spriteRenderer.color = col;
    }
    void pickARandomSprite()
    {
        //spriteRenderer.sprite = mySprite;
        randomnum = Random.Range(0,berrel0.Count);
       spriteRenderer.sprite = berrel0[randomnum];

    }
    
}
