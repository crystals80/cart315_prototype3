using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject Player;
    public GameObject ToDoorOne;
    public GameObject ToDoorTwo;
    public GameObject ToDoorThree;
    public GameObject ToDoorFour;
    public GameObject ToDoorFive;
    public GameObject ToDoorSix;
    public GameObject ToDoorSeven;
    public GameObject ToDoorEight;
    public GameObject ToDoorNine;
    public GameObject ToDoorTen;
    public GameObject ToDoorEleven;
    public GameObject ToDoorTwelve;
    public GameObject ToGoldDoor;

    //public AudioSource TeleportSound;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("DoorOne"))
        {
            Player.transform.position = ToDoorThree.transform.position;
            //TeleportSound.Play();
        }

        if (collision.gameObject.CompareTag("DoorTwo"))
        {
            Player.transform.position = ToDoorSix.transform.position;
            //TeleportSound.Play();
        }

        if(collision.gameObject.CompareTag("DoorThree"))
        {
            Player.transform.position = ToDoorTwo.transform.position;
            //TeleportSound.Play();
        }

        if (collision.gameObject.CompareTag("DoorFour"))
        {
            Player.transform.position = ToDoorNine.transform.position;
            //TeleportSound.Play();
        }
        if (collision.gameObject.CompareTag("DoorFive"))
        {
            Player.transform.position = ToDoorOne.transform.position;
            //TeleportSound.Play();
        }

        if (collision.gameObject.CompareTag("DoorSix"))
        {
            Player.transform.position = ToDoorFour.transform.position;
            //TeleportSound.Play();
        }

        if (collision.gameObject.CompareTag("DoorSeven"))
        {
            Player.transform.position = ToDoorTwelve.transform.position;
            //TeleportSound.Play();
        }

        if (collision.gameObject.CompareTag("DoorEight"))
        {
            Player.transform.position = ToDoorEight.transform.position;
            //TeleportSound.Play();
        }
        if (collision.gameObject.CompareTag("DoorNine"))
        {
            Player.transform.position = ToDoorFive.transform.position;
            //TeleportSound.Play();
        }

        if (collision.gameObject.CompareTag("DoorTen"))
        {
            Player.transform.position = ToDoorEleven.transform.position;
            //TeleportSound.Play();
        }

        if (collision.gameObject.CompareTag("DoorEleven"))
        {
            Player.transform.position = ToDoorNine.transform.position;
            //TeleportSound.Play();
        }

        if (collision.gameObject.CompareTag("DoorTwelve"))
        {
            Player.transform.position = ToDoorTen.transform.position;
            //TeleportSound.Play();
        }

        if (collision.gameObject.CompareTag("GoldDoor"))
        {
            Player.transform.position = ToGoldDoor.transform.position;
            //TeleportSound.Play();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
