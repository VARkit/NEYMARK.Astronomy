using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject Player;
    public Transform HoleRoomPoint;
    public Transform SolarRoomPoint;

    public GameObject GoldStarForSun;
    public GameObject GoldStarForHole;

    private void Awake()
    {
        string level = DataSaverStruct.NameClassroom;

        if (level == "Solar")
        {
            Player.transform.position = new Vector3(SolarRoomPoint.position.x,
                                                   Player.transform.position.y,
                                                   SolarRoomPoint.position.z);

        }
        else if (level == "Hole")
        {
            Player.transform.position = new Vector3(HoleRoomPoint.position.x,
                                                   Player.transform.position.y,
                                                   HoleRoomPoint.position.z);
        }
    }
}
