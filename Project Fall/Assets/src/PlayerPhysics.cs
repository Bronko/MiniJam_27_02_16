using UnityEngine;
using System.Collections;

public class PlayerPhysics : MonoBehaviour {

    public Transform Planet;

    private Rigidbody myRB;

    public float force = 128f;

    public void Awake()
    {
        myRB = GetComponent<Rigidbody>();
       // Physics.gravity = new Vector3(0, -1.0F, 0);
    }

	// Use this for initialization
	void Start () {
	
	}
	

    public void FixedUpdate()
    {
        Vector3 offset = transform.position - Planet.position;


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localRotation *= Quaternion.Euler(0, -force, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localRotation *= Quaternion.Euler(0, force, 0);
        }

        myRB.AddRelativeForce(0, 0, 120f);

        Vector3 vel = myRB.velocity;
        vel.Normalize();
        offset = vel - transform.position;
        transform.LookAt(Planet, vel);

        transform.Rotate(Vector3.left, 110);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            myRB.AddRelativeForce(0, 0, 320f);
        }

        
    }

}
