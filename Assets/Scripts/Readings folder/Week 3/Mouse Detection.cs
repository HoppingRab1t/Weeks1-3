using TreeEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseDetection : MonoBehaviour
{
    public bool leftPress;
    public bool rightPress;
    public bool MousePressed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftPress = Mouse.current.leftButton.isPressed;
        rightPress = Mouse.current.rightButton.isPressed;


        MousePressed = Mouse.current.leftButton.wasPressedThisFrame;

        //if (MousePressed == true)
        //{
        //    Debug.Log("IT HAS BEEN PRESSED");
        //}
        if (Keyboard.current.dKey.isPressed == true)
        {
            Vector3 angle = transform.eulerAngles;
            angle.z += 100 * Time.deltaTime;
            transform.eulerAngles = angle;
        }
        if (Keyboard.current.aKey.isPressed == true)
        {
            Vector3 angles = transform.eulerAngles;
            angles.z -= 100 * Time.deltaTime;
            transform.eulerAngles = angles;
        }
        if (Keyboard.current.wKey.isPressed == true)
        {
            transform.position += transform.up * 10 * Time.deltaTime;
        }
        if (Keyboard.current.sKey.isPressed == true)
        {
            transform.position -= transform.up * 10 * Time.deltaTime;
        }
    }
}
