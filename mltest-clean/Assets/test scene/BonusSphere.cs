using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Roundbeargames
{
    public class BonusSphere : MonoBehaviour
    {
        public bool Collided;

        private void Start()
        {
            Collided = false;
        }

        public void OnTriggerStay(Collider other)
        {
            if (!Collided)
            {
                Collided = true;
                Debug.Log(other.gameObject.name + " collided!");
            }
        }
    }
}