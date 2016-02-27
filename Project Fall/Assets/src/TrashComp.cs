using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.src
{
    public class TrashComp : MonoBehaviour
    {
        int ticks = 0;
        void Update()
        {
            ticks++;
            if (ticks > 800)
            {
                Destroy(gameObject);
            }
        }

        void OnTriggerEnter(Collider col)
        {
            if (col.gameObject.name == "Player")
            {
                Destroy(gameObject);
            }
        }
    }


}
