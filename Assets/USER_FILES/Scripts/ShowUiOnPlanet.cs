using UnityEngine;

public class ShowUiOnPlanet : MonoBehaviour
{
    // UI � ���� � �������
    public GameObject UI;

    // ���� �� �������� � ������ ������
    private bool _collisionValid = false;
    private void OnTriggerEnter(Collider other)
    {
        print("CALL");
        if (other.gameObject.tag == "Player")
        {
            UI.SetActive(true);
        }
    }

    private void Update()
    {
        if (!_collisionValid){
            UI.SetActive(false);
        }
    }
}
