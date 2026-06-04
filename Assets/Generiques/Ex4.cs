using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class Ex4 : MonoBehaviour
{
    public GameObject Prefab;
    
    private void Start()
    {
        ObjectPool<Cube> pool = new ObjectPool<Cube>();
      //  pool.Prefab = Prefab;
        GameObject instantiate = pool.Get().gameObject;
    }
}

public class ObjectPool<T> where T : Component
{
    private List<T> Objects = new List<T>();
    public T Prefab;

    public T Get()
    {
        foreach (T obj in Objects)
        {
            if (!obj.gameObject.activeInHierarchy) return obj;
        }

        T newObj = Object.Instantiate(Prefab);
        Objects.Add(newObj);
        return newObj;
    }
}

public class Cube : MonoBehaviour
{
    
}