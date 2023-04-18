using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    // Я хз че это за параметр, но чем больше, тем быстрее
    public float Period = 2;

    private void FixedUpdate()
    {
        // Крутим-вертим
        transform.Rotate(0, Period, 0);
    }
}
