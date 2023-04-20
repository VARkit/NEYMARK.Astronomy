using UnityEngine;

public class RotationAroundWiithoutRotation : MonoBehaviour
{
    public Transform Center;
    public float Radius = 2f;
    public float AngularSpeed = 2f;
    private float posX, posY, angle = 0f;

    public int Mode = 1;
    
    void Update()
    {
        if (Mode == 1)
        {
            posX = Center.position.x + Mathf.Cos(angle) * Radius;
            posY = Center.position.y + Mathf.Sin(angle) * Radius;
            transform.position = new Vector3(posX, posY, transform.position.z);
        }
        else if (Mode == 2) {
            posX = Center.position.x + Mathf.Cos(angle) * -Radius;
            posY = Center.position.y + Mathf.Sin(angle) * Radius;
            transform.position = new Vector3(posX, transform.position.y, posY);
        }
        
        angle += Time.deltaTime * AngularSpeed;

        if (angle >= 360){
            angle = 0;
        }
    }
}
