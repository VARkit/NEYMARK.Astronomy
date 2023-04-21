using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSunScene : MonoBehaviour
{
    public GameObject GoldStar;
    private void OnTriggerEnter(Collider other)
    {
        print("CALL");
        if (other.gameObject.tag == "Player")
        {
            GoldStar.SetActive(true);
            SceneManager.LoadScene("TheSolarSystem");
        }
    }
}
