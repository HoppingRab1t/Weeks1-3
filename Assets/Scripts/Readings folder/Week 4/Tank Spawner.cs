using System.Security.Principal;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankSpawner : MonoBehaviour
{
    public GameObject tankPrefab;
    public int howMnayTanks = 0;

    public GameObject spawnedTank;

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
            spawnedTank = Instantiate(tankPrefab, transform.position, transform.rotation );
            tankScript = spawnedTank.GetComponent<FirstScript>();

            Vector2 spawnPos = Random.insideUnitCircle * 5;

            //Quanternion identiy menas no rotation which sets all of the angles to 0,0,0
            //Instantiate(tankPrefab, spawnPos, Quaternion.identity);

            howMnayTanks += 1;

            //changing the values in the script.
            tankScript.movement = howMnayTanks;
        }



        //if (Mouse.current.leftButton.wasPressedThisFrame)
        //{
        //    Instantiate(tankPrefab, transform);
        //}
    }
}
