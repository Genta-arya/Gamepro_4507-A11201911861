using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoadHscore : MonoBehaviour
{
    // Start is called before the first frame update
    public static int h_score = 0;
    public Text TextH_Score;
    void Start()
    {
        TextH_Score.text = "Koin Tertinggi = " + LoadHighScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static int LoadHighScore(){
        if ( !PlayerPrefs.HasKey("highscore"))
            PlayerPrefs.SetInt("highscore",0);
        else
            h_score = PlayerPrefs.GetInt("highscore");
        return h_score;
    }
    public static void SaveHighScore(int hs){
        int h_score = 0;
        if(!PlayerPrefs.HasKey ("highscore"))
            PlayerPrefs.SetInt("highscore",0);
        else{
            h_score = PlayerPrefs.GetInt("highscore");
            h_score = ObjectMovement.hs ;
            PlayerPrefs.SetInt("highscore",h_score);
        }
    }
}
