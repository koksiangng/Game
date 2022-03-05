using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public float speed = 1.0f;
    
    public float movespeed;
    
    public float increasespeed;

    private float maxspeed = 5f;

    private GameObject player;
    private Rigidbody rb;
       
    // Start is called before the first frame update
    void Start()
    {
        increasespeed = 0;
        player = this.gameObject;
        rb = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Controller();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("bef");
        if (collision.transform.tag == "Wall")
        {
            Debug.Log("aft");
            //rb.velocity = Vector3.zero;
        }
        
    }

    private void Controller()
    {
        float z = 0.0f;

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A");
            z += 100f;
            
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D");
            z -= 100f;
            
        }
        rb.AddForce(0, 0, z, ForceMode.Impulse);


    }
}
