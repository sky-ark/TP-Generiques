using System;
using UnityEngine;

namespace Generiques
{
    public class Ex1 : MonoBehaviour
    {
        public T FindComponent<T>() where T : Component
        {
            return GetComponent<T>();
        }

        private void Start()
        {
            Transform objectTransform = FindComponent<Transform>();
            Debug.Log(objectTransform.position);
            MeshRenderer objectRenderer = FindComponent<MeshRenderer>();
            Debug.Log(objectRenderer);
        }
    }
}
