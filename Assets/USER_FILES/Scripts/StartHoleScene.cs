using UnityEngine;
using UnityEngine.SceneManagement;

public class StartHoleScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            SceneManager.LoadScene("TheBlackHole");
        }
    }
}
