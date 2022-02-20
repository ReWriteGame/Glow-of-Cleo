using UnityEngine;
using UnityEngine.Events;

public class MoveObjectOnPoint : MonoBehaviour
{
    [SerializeField] private Transform moveObject;

    public UnityEvent objectMovedEvent;

    public void MoveObjectToPosition()
    {
        moveObject.position = new Vector3(transform.position.x, transform.position.y, moveObject.position.z);
        objectMovedEvent?.Invoke();
    }
    
    
}