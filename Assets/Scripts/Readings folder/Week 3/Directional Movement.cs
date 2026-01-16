using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class DirectionalMovement : MonoBehaviour
{
    public float speed = 1.0f;
    public float rotSpeed = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.x += speed * Time.deltaTime;
        transform.position = newPos;

        //the other way of changing the positon but rotation could affect since it uses the direction of the object as reference
        //transform.position += transform.right * speed * Time.deltaTime;

        Vector3 newRotation = transform.eulerAngles;
        newRotation.z += rotSpeed * Time.deltaTime;
        transform.eulerAngles = newRotation;
    } 
}
