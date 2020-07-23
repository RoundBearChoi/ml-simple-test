using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Roundbeargames
{
    [CustomEditor(typeof(TestingEnvironment))]
    public class TestingEnvironmentEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            if (GUILayout.Button("Reset All Positions"))
            {
                Debug.Log("Resetting All Positions");
                TestingEnvironment e = (TestingEnvironment)target;
                e.ResetAllPositions();
            }
        }
    }
}