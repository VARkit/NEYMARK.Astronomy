using UnityEngine;

public class ShowUiOnPlanet : MonoBehaviour
{
    // UI с информацией
    public GameObject UI;
    // якорь планеры
    public Transform Anchor;

    private void Update()
    {
        if (Vector3.Distance(transform.position, Anchor.position) > 0.2f){
            UI.SetActive(true);
        } else {
            UI.SetActive(false);
        }
    }
}
