using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MoveToHole : MonoBehaviour
{
    public Transform Hole;
    public float Duration;
    public float TimerTime;
    private void Start()
    {
        TimerTime = Duration + 2;
        StartCoroutine(LerpCorutine(transform.position, Hole.position, Duration));
    }

    private IEnumerator LerpCorutine(Vector3 pos1, Vector3 pos2, float duration)
    {
        for (float t = 0f; t < duration; t += Time.deltaTime)
        {
            transform.position = Vector3.Lerp(pos1, pos2, t / duration);
            yield return 0;
        }
        transform.position = pos2;
    }
    private void Update()
    {
        TimerTime -= Time.deltaTime;
        if (TimerTime < 0)
        {
            SceneManager.LoadScene("LearnBlackHole");
        }
    }
}
