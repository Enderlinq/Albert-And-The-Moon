using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlbertControls : MonoBehaviour
{
    Rigidbody AlbertRB;
    void Start()
    {
        AlbertRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Thrust();
        Rotation();

        void Thrust()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                AlbertRB.AddRelativeForce(Vector3.up);
            }
        }

        void Rotation()
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.back);
            }

            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.forward);
            }

        }
        
    }

}
