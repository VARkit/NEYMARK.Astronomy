using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionWithHole : MonoBehaviour
{
    public float AudioTime;
    private void Update()
    {
        AudioTime -= Time.deltaTime;

        if (AudioTime < 0){
            SceneManager.LoadScene("LearnBlackHole");
        }
    }
}
