using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public SpriteRenderer sr;
    public  static string currentcolor;
    public Color colorCyan;
    public Color colorYellow;
    public Color colorMagenta;
    public Color colorPink;
    // Start is called before the first frame update
    void Start()
    {
        SetRandomColor();
    }
    private void SetRandomColor(){
        int inde= Random.Range(0,4);
       
        switch (inde){
            case 0:
            currentcolor="Yellow";
            sr.color=colorYellow;
            break;
            case 1:
            currentcolor="Cyan";
            sr.color=colorCyan;
            break;
            case 2:
            currentcolor="Magenta";
            sr.color=colorMagenta;
            break;
            case 3:
            currentcolor="Pink";
            sr.color=colorPink;
            break;
        }
    }
}
