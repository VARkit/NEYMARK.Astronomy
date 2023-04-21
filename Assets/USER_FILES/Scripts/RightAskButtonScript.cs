using UnityEngine.UI;
using UnityEngine;

public class RightAskButtonScript : MonoBehaviour
{
    public Image BgColor;
    public GameObject GoldStarPlane;
    public void Press(){
        BgColor.color = Color.green;
        GoldStarPlane.SetActive(true);
    }
}
