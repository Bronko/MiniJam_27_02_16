using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.src
{

    public class GravityComponent : MonoBehaviour
    {
        private Rigidbody myRB;

        public Transform Reference;

        public static float pull = -610f;

        public void Awake()
        {
            myRB = GetComponent<Rigidbody>();
        }

        public void FixedUpdate()
        {
            Vector3 offset =  transform.position - Reference.transform.position;
            offset.Normalize();
            myRB.AddForce(offset * pull);
        }
    }
}
