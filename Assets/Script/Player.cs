
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float jumForce=20f;
    public Rigidbody2D rb;
    public string currentcolor;
    public SpriteRenderer sr;
    public Color colorCyan;
    public Color colorYellow;
    public Color colorMagenta;
    public Color colorPink;
    public int index;
    public TMP_Text scoreText;
    private int Score=0;
    void Start(){
        SetRandomColor();
       UpdateScoreText();
    }
    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetButtonDown("Jump")|| Input.GetMouseButtonDown(0)){
            rb.velocity=Vector2.up*jumForce;
        }
    }
    void OnTriggerEnter2D(Collider2D col){
        if(col.tag==currentcolor){
            Score+=1;
            UpdateScoreText();
        }
        else if(col.tag!="colorChanger"){
            int sce=4;
            SceneManager.LoadScene(sce);
        }
        if(col.tag=="colorChanger"){
            currentcolor=changeColor.currentcolor;
            switch(currentcolor){
                case "Yellow":
                sr.color=colorYellow;
                break;
                case "Cyan":
                sr.color=colorCyan;
                break;
                case "Magenta":
                sr.color=colorMagenta;
                break;
                case "Pink":
                sr.color=colorPink;
                break;
            }
        }

    }
    private void SetRandomColor(){
        index= Random.Range(0,4);
        switch (index){
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
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + Score;
    }
}
