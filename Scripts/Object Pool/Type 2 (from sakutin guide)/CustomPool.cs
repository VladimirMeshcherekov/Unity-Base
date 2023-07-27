using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject objectContainer;
    [SerializeField] private int containerCapacity;
    private List<GameObject> pool = new List<GameObject>();

    protected void Initialize(GameObject prefab)
    {
        for (int i = 0; i < containerCapacity; i++)
        {
            GameObject spawned = Instantiate(prefab, objectContainer.transform);
            spawned.SetActive(false);
            pool.Add(spawned);
        }
    }

    protected bool TryGetObject(out GameObject result)
    {
        result = pool.FindAll(p => p.activeSelf == false);
        return result != null;
    }
}