using UnityEngine;

public class ShowUiOnPlanet : MonoBehaviour
{
    // UI с инфо о планете
    public GameObject UI;

    // Есть ли коллизия в данный момент
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
