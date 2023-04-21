using UnityEngine;

public class LerpObjToHole : MonoBehaviour
{
    public GameObject Me;
    public Transform Hole;
    public float CastDistanse = 2f;
    public float LerpSpeed = 20f;
    public float DeathDistanse = 400f;

    private float _originDistanse;
    private bool _valid = false;

    public bool EnableGravity = false;
    private void Start()
    {
        _originDistanse = Vector3.Distance(transform.position, Hole.position);
    }
    void Update()
    {
        if (Vector3.Distance(transform.position, Hole.position) < _originDistanse - CastDistanse)
        {
            _valid = true;
        }

        if (_valid)
        {
            transform.position = Vector3.Lerp(transform.position, Hole.position, LerpSpeed);
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.useGravity = EnableGravity;

            if (Vector3.Distance(transform.position, Hole.position) < DeathDistanse)
            {
                Destroy(Me);
            }
        }
    }
}
