using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemProducer : BaseProducer
{
    [SerializeField] private float _counter;
    [SerializeField] private float _maxDelayCount;
    private float _yValue;
    
    [SerializeField] private ObjectVault _vault;
    public CubeStore Store;

    private float ElapsedTime
    {
        get => _counter;
        set => _counter = value;
    }

    private float MaximumTime
    {
        get => _maxDelayCount;
    }

    private float Height
    {
        get => _yValue;
        set => _yValue = value;
    }

    private void Update()
    {
        ProduceItem();
    }

    private void ProduceItem()
    {
        ElapsedTime += Time.deltaTime;

        if (ElapsedTime >= MaximumTime)
        {
            ElapsedTime = 0;
            var spawnedObject = SpawnTargetItem(_vault._object, Height);
            Store.EnqueueData(spawnedObject);
            Height += 0.5f;
        }
    }


    protected override GameObject SpawnTargetItem(GameObject _targetItem, float _yValue)
    {
        Debug.Log("Produced Item");
        return base.SpawnTargetItem(_targetItem, _yValue);
    }
}
