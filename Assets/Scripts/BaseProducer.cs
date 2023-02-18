using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseProducer : MonoBehaviour
{
    protected virtual GameObject SpawnTargetItem(GameObject _targetItem, float _yValue)
    {
        Vector3 _desiredPosition = new Vector3(0, _yValue, 0);
        GameObject _spawnedObject = Instantiate(_targetItem, _desiredPosition , Quaternion.identity);

        return _spawnedObject;
    }
}
