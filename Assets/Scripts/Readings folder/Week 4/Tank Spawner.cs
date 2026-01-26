using System.Collections.Generic;
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


    public List<GameObject> tanks;
    public Transform barrel;
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
            tankScript.body.color = Random.ColorHSV();

            tanks.Add(spawnedTank);

            for (int i = 0; i <tanks.Count; i++)
            {
                FirstScript ts = tanks[i].GetComponent<FirstScript>();    
                tankScript.movement = howMnayTanks;

            }
        }
        for (int i = 0; i < tanks.Count; i++)
        {
            float distance = Vector2.Distance(tanks[i].transform.position, barrel.position); 
            if (distance < 0.5f)
            {
                Debug.Log("tank " + i + " expoded");
            }
        }

        

        //if (Mouse.current.leftButton.wasPressedThisFrame)
        //{
        //    Instantiate(tankPrefab, transform);
        //}
    }
}
