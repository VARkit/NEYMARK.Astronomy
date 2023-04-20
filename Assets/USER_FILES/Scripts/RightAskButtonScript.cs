using UnityEngine.UI;
using UnityEngine;

public class RightAskButtonScript : MonoBehaviour
{
    public Image BgColor;
    //public MeshRenderer Star;
    //public Material NewStarMaterial;
    public void Press(){
        BgColor.color = Color.green;
        //Star.material = NewStarMaterial;
    }
}
