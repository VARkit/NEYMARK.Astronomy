using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    // � �� �� ��� �� ��������, �� ��� ������, ��� �������
    public float Period = 2;

    private void FixedUpdate()
    {
        // ������-������
        transform.Rotate(0, Period, 0);
    }
}
