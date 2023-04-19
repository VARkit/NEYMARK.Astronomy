using UnityEngine;

public class ShowUiOnPlanet : MonoBehaviour
{
    // UI � �����������
    public GameObject UI;
    // ����� �������
    public Transform Anchor;

    private void Update()
    {
        print(Vector3.Distance(transform.position, Anchor.position));
        if (Vector3.Distance(transform.position, Anchor.position) > 0.2f){
            UI.SetActive(true);
        } else {
            UI.SetActive(false);
        }
    }
}
