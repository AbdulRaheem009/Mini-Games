using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScenceManage : MonoBehaviour
{
    // Start is called before the first frame update
    private int index;

    public void MainManue()
    {
        index=0;
        SceneManager.LoadScene(index);
        
    }
    public void StartGame(){
        index=1;
        SceneManager.LoadScene(index);

    }
    public void PlayAgain(){
        index=1;
        SceneManager.LoadScene(index);
    }
    public void SwitchColor(){
        index=3;
        SceneManager.LoadScene(index);
    }
    
}
