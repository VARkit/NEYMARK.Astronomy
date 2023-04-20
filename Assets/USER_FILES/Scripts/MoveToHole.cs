using UnityEngine;

public class MoveToHole : MonoBehaviour
{
    public Transform Hole;
    public float Speed = 2f;
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, Hole.position, Speed);
    }
}
