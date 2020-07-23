using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Roundbeargames
{
    public class AICube : MonoBehaviour
    {
        public float Speed;

        Rigidbody rb;
        TestingEnvironment env;

        private void Start()
        {
            rb = this.gameObject.GetComponent<Rigidbody>();
            env = this.gameObject.GetComponentInParent<TestingEnvironment>();
        }

        private void FixedUpdate()
        {
            if (!InvalidPress())
            {
                if (Input.GetKey(KeyCode.A))
                {
                    rb.MovePosition(rb.position - (Vector3.right * Speed));
                }

                if (Input.GetKey(KeyCode.D))
                {
                    rb.MovePosition(rb.position + (Vector3.right * Speed));
                }
            }

            if (env.bonusSphere.Collided)
            {
                env.ResetAllPositions();
            }

            if (OutOfBounds())
            {
                env.ResetAllPositions();
            }
        }

        bool InvalidPress()
        {
            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
            {
                return true;
            }

            return false;
        }

        bool OutOfBounds()
        {
            if (this.transform.position.x < env.LeftEdge.transform.position.x)
            {
                return true;
            }

            if (this.transform.position.x > env.RightEdge.transform.position.x)
            {
                return true;
            }

            return false;
        }
    }
}