using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int HealthPoints = 10;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bomb"))
        {
            HealthPoints = HealthPoints - 10;
            //bombsound
            Destroy(other.gameObject);
            
        }

        /*if (other.gameObject.CompareTag("DedBomb"))
        {
            //maybe as a gig, or if there are ice bergs that will happen
        }*/

        if (other.gameObject.CompareTag("Bullet"))
        {
            HealthPoints = HealthPoints - 1;
            //bullet hitting sound
            Destroy(other);
        }
    }

}
