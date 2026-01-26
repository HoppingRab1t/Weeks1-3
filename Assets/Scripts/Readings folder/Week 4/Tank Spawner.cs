using System.Security.Principal;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankSpawner : MonoBehaviour
{
    public GameObject tankPrefab;
    public int howMnayTanks = 0;

    public FirstScript tankScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            //Instantiate(tankPrefab, transform.position, transform.rotation );

            Vector2 spawnPos = Random.insideUnitCircle * 5;

            //Quanternion identiy menas no rotation which sets all of the angles to 0,0,0
            Instantiate(tankPrefab, spawnPos, Quaternion.identity);

            howMnayTanks += 1;
        }
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Instantiate(tankPrefab, transform);
        }
    }
}
