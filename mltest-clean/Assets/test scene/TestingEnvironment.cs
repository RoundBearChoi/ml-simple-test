using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Roundbeargames
{
    public class TestingEnvironment : MonoBehaviour
    {
        public AICube aiCube;
        public BonusSphere bonusSphere;
        public EdgeSphere LeftEdge;
        public EdgeSphere RightEdge;

        public void ResetAllPositions()
        {
            bonusSphere.Collided = false;
            bonusSphere.transform.position = GetRandom();

            aiCube.transform.position = GetRandom();
        }

        Vector3 GetRandom()
        {
            Vector3 Line = LeftEdge.transform.position - RightEdge.transform.position;
            float mag = Line.magnitude;
            float rand = Random.Range(0f, mag);
            Vector3 randomPos = LeftEdge.transform.position + (Vector3.right * rand);

            return randomPos;
        }
    }
}