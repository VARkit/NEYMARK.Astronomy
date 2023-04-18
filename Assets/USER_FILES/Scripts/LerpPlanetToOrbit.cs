using UnityEngine;

public class LerpPlanetToOrbit : MonoBehaviour
{
    // якорь планеты на орбите
    public Transform Anchor;
    // —корость возвращени€ на орбиту
    public float Speed;
    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, Anchor.position, Speed);
    }
}
