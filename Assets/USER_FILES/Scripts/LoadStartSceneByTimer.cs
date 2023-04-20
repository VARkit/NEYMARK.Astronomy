using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStartSceneByTimer : MonoBehaviour
{
    public float TimerTime;
    public string RoomName;
    void Update()
    {
        TimerTime -= Time.deltaTime;

        if (TimerTime < 0)
        {
            SceneManager.LoadScene("StartScene");
            DataSaverStruct.NameClassroom = RoomName;
        }
    }
}
