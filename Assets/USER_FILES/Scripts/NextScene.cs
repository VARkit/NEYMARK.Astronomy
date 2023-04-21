using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            SceneManager.LoadScene("StartScene");
            DataSaverStruct.NameClassroom = "Hole";
        }
    }
}
