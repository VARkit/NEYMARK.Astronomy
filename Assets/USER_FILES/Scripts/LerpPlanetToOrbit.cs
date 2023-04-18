using UnityEngine;

public class LerpPlanetToOrbit : MonoBehaviour
{
    // ����� ������� �� ������
    public Transform Anchor;
    // �������� ����������� �� ������
    public float Speed;
    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, Anchor.position, Speed);
    }
}
