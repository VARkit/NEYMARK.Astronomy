using UnityEngine;

public class GoldStarSetActive : MonoBehaviour
{
    public GameObject GoldStar;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            GoldStar.SetActive(true);
        }
    }
}
