using UnityEngine;

public class UiRotateToPlayer : MonoBehaviour
{
    public Transform PlayerCamera;
    
    void Update()
    {
        transform.LookAt(PlayerCamera);
    }
}
