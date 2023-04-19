using UnityEngine;

public class LerpObjToHole : MonoBehaviour
{
    public GameObject Me;
    public Transform Hole;
    public float CastDistanse = 2f;
    public float LerpSpeed = 20f;

    private float _originDistanse;
    private bool _valid = false;
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
            rb.useGravity = false;

            if (Vector3.Distance(transform.position, Hole.position) < 30)
            {
                Destroy(Me);
            }
        }
    }
}
