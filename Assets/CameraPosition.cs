using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public Transform target;

    void FixedUpdate()
    {
        Vector3 newPosition = target.position;
        newPosition.z = -10;

        transform.position = newPosition;
    }
}
