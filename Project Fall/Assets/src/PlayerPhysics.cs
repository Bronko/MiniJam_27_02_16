using UnityEngine;
using System.Collections;

public class PlayerPhysics : MonoBehaviour {

    public GameObject Planet;

    private Rigidbody myRB;

    public float force = 48f;

    public void Awake()
    {
        myRB = GetComponent<Rigidbody>();
       // Physics.gravity = new Vector3(0, -1.0F, 0);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 offset = transform.position - Planet.transform.position;
        offset.Normalize();

      

        if (Input.GetKey(KeyCode.LeftArrow))
        {
          //  transform.Rotate(0, -force , 0, Space.World);
        }

        

	}

    public void FixedUpdate()
    {
        Vector3 offset = transform.position - Planet.transform.position;


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localRotation *= Quaternion.Euler(0, -force, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localRotation *= Quaternion.Euler(0, force, 0);
        }

        myRB.AddRelativeForce(0, 0, 40f);

        Vector3 vel = myRB.velocity;
        vel.Normalize();
        offset = vel - transform.position;
        transform.LookAt(Planet.transform, vel);

        transform.Rotate(Vector3.left, 90);
    }
}
