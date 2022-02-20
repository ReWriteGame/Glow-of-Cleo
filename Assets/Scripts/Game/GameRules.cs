using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRules : MonoBehaviour
{
    [SerializeField]private MoveObjectOnPoint[] points;

    public void SetRandomPosition()
    {
        points[Random.Range(0,points.Length)].MoveObjectToPosition();
    }
}
