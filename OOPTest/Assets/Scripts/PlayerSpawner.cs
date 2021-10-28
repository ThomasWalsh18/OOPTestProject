using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject Player;
    [SerializeField]
    private GameObject PIndicator;

    public GameObject[] Players;
    public  GameObject[] PlayerChoices;
    int choice = 0;

    private bool started = false;
    void Start()
    {
       
        
    }

    void cycle(GameObject[] Array)
    {
        for(int i = 0; i < Array.Length; i++)
        {
            if(i != choice)
            {
                Array[i].SetActive(false);
            } else
            {
                Array[i].SetActive(true);
            }
        }
    }

    void Update()
    {
        if (!started) //Seeing if the game has started
        {
            if (Input.GetKeyDown(KeyCode.Return)) //Checking to see when the player has made their decision
            {
                //Spawn the player and set the indicator to false
                Player.transform.position = PIndicator.transform.position;
                Player.SetActive(true);
                cycle(Players);
                PIndicator.SetActive(false);

                started = true;
            }
            //ABSTRACTION
            if (Input.GetKeyDown(KeyCode.Alpha1) && choice != 0) //Player Chose The First element
            {
                choice = 0;
                cycle(PlayerChoices);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2) && choice != 1) //Player Chose The Second elemnt
            {
                choice = 1;
                cycle(PlayerChoices);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3) && choice != 2) //Player Chose The Third elemnt
            {
                choice = 2;
                cycle(PlayerChoices);
            }


            //Movement of the player Spawner
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                PIndicator.transform.position += new Vector3(-1,0,0);
            } 
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                PIndicator.transform.position += new Vector3(1, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                PIndicator.transform.position += new Vector3(0, 1, 0);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                PIndicator.transform.position += new Vector3(0, -1, 0);
            }
        }
    }
}
