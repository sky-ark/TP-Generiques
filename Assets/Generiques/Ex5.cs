using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Generiques
{
    public class Ex5 : MonoBehaviour
    {
        public class Repository<T> : List<T> where T : Component
        {
            public List<T> Items = new List<T>();

            public void Add(T item)
            {
                Items.Add(item);
            }

            public void Remove(T item)
            {
                Items.Remove(item);
            }

            public T Get(int index)
            {
               return Items[index];
            }
        }

        private void Start()
        {
            Repository<Transform> transformRepository = new Repository<Transform>();
            transformRepository.Add(transform);
            
        }
    }
}