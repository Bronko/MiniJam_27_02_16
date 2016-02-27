using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.src
{

    public class RotationComponent : MonoBehaviour
    {
        private Rigidbody myRB;

        public Transform Reference;

        public void Awake()
        {
            myRB = GetComponent<Rigidbody>();
        }

        public void FixedUpdate()
        {
            
        }
    }
}
