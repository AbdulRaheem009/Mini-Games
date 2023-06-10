using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class GridSpace : MonoBehaviour
{
    public Button button;
    public TMP_Text buttonText;
    private string playerSide;
    private static int clickCount;
    private static string[] arr= new string[9] {"","","","","","","","",""};
    private int index;
    
    public void SetSpace()
    {
        clickCount++;
        if (clickCount % 2 == 0)
        {
            playerSide="O";
        }
        else
        {
            playerSide="X";
        }
        buttonText.text = playerSide;
        button.interactable = false;
        index=GetButtonIndex()-6;
        arr[index]=playerSide;
        // Debug.Log(string.Join(", ", arr));
         if (CheckWinCondition(playerSide))
        {
            int scen=2;
            SceneManager.LoadScene(scen);
        }
    }
    private int GetButtonIndex()
    {
        return transform.GetSiblingIndex();
    }
    private bool CheckWinCondition(string side)
    {
         if ((arr[0] == side && arr[1] == side && arr[2] == side) || (arr[6] == side && arr[7] == side && arr[8] == side) || (arr[3] == side && arr[4] == side && arr[5] == side) )
        return true;
        // // Vertical win conditions
        if ((arr[0] == side && arr[3] == side && arr[6] == side) || (arr[1] == side && arr[4] == side && arr[7] == side) || (arr[2] == side && arr[5] == side && arr[8] == side) )
        return true;
        // // Diagonal win conditions
        if ((arr[0] == side && arr[4] == side && arr[8] == side) || (arr[2] == side && arr[4] == side && arr[6] == side) )
        return true;

        return false;
    }
}