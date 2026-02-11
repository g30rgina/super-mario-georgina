using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour 
{ 
    public GameObject pauseCanvas;
    public Text goombaText;

    private bool pause;

    public int killedEnemies = 0;
    
    public void Addkill()
    {
        killedEnemies++;
    goombaText.text = killedEnemies.ToString();
    }  

    void Pause () 
    { 
        if(_pause == false)
        { 
        Time.timeScale = 0; 
        pause
        _pause = true;
        } 
        else
        {
        Time.timeScale = 1;
        _pause = false;
        }
}

}



