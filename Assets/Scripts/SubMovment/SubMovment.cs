using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMovment : MonoBehaviour
{

    float Speed = 90.0F;

    float SpeedMovent = 10.0F;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalMovement = Input.GetAxis("Horizontal") * Speed;
        HorizontalMovement *= Time.deltaTime;

        transform.Rotate(0, 0, -HorizontalMovement);


        float VerticalMovement = Input.GetAxis("Vertical") * SpeedMovent;
        VerticalMovement *= Time.deltaTime;

        transform.Translate(0, -VerticalMovement, 0);
        

        
        
    }
}
