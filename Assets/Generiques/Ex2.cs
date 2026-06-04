using System;
using UnityEngine;

namespace Generiques
{
    public class Ex2 : MonoBehaviour
    {
        public T FindObjectOfTypeGeneric<T>() where T : Component
        {
            return FindObjectOfType<T>();
        }

        private void Start()
        {
            Camera mainCamera = FindObjectOfTypeGeneric<Camera>();
            Debug.Log(mainCamera.name);
            Light mainLight = FindObjectOfTypeGeneric<Light>();
            Debug.Log(mainLight.intensity);
        }
    }
}