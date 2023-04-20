using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSunScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            SceneManager.LoadScene("TheSolarSystem");
        }
    }
}
