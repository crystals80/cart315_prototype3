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
            Player.transform.position = ToDoorThree.transform.position;
            //TeleportSound.Play();
        }

        if(collision.gameObject.CompareTag("DoorThree"))
        {
            Player.transform.position = ToDoorTwo.transform.position;
            //TeleportSound.Play();
        }

        if (collision.gameObject.CompareTag("DoorFour"))
        {
            Player.transform.position = ToDoorOne.transform.position;
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
