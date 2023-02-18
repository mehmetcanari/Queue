using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(menuName = "Store")]
public class CubeStore : ScriptableObject
{
    public Queue<GameObject> queuedObjects = new Queue<GameObject>();

    public void EnqueueData(GameObject _targetData)
    {
        queuedObjects.Enqueue(_targetData);
    }

    public void ClearData()
    {
        queuedObjects = new Queue<GameObject>();
    }

    private void OnEnable()
    {
        ClearData();
    }
}