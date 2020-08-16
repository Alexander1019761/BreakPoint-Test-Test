using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float moveSpeed = 5;
    public float turnSpeed = 100;
    public float jumpHeight = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(Time.deltaTime);

        if( Input.GetKey(KeyCode.W) == true )
        {
            this.transform.position += this.transform.forward * Time.deltaTime * this.moveSpeed;
        }

        if (Input.GetKey(KeyCode.S) == true)
        {
            this.transform.position -= this.transform.forward * Time.deltaTime * this.moveSpeed;
        }

        if (Input.GetKey(KeyCode.D) == true)
        {
            this.transform.position += this.transform.right * Time.deltaTime * this.moveSpeed;
        }

        if (Input.GetKey(KeyCode.A) == true)
        {
            this.transform.position -= this.transform.right * Time.deltaTime * this.moveSpeed;
        }

        if (Input.GetKey(KeyCode.Space) == true && Mathf.Abs(this.GetComponent<Rigidbody>().velocity.y) < 0.01f)
        {
            this.GetComponent<Rigidbody>().velocity += Vector3.up * this.jumpHeight;
        }

                if (Input.GetKey(KeyCode.LeftShift) == true)
        {
            moveSpeed = 10;
        }

        else
        {
            moveSpeed = 5;
        }
    }
}
