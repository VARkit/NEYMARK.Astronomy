using UnityEngine;

public class RotationAroundWiithoutRotation : MonoBehaviour
{
    public Transform Center;
    public float Radius = 2f;
    public float AngularSpeed = 2f;
    private float posX, posY, angle = 0f;
    
    void Update()
    {
        posX = Center.position.x + Mathf.Cos(angle) * Radius;
        posY = Center.position.y + Mathf.Sin(angle) * Radius;
        transform.position = new Vector3(posX, posY, transform.position.z);
        angle += Time.deltaTime * AngularSpeed;

        if (angle >= 360){
            angle = 0;
        }
    }
}
