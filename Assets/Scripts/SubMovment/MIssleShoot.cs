using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MIssleShoot : MonoBehaviour
{

   // private bool ShootOkay = false;

    //private float Delay = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootOkay = true;

            Invoke("NoShoot", Delay);
        }*/
    }

    /*private void NoShoot()
    {
        ShootOkay = false;
    }*/

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Bomb"))
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Ship"))
        {
                Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("LessMoveingShip"))
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("AirCraft"))
        {
            Destroy(other.gameObject);
        }

    }
}
