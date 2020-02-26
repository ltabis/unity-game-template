using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveScore : MonoBehaviour
{
    // Set the current score of the player.
    void SetScore(int score)
    {
        PlayerPrefs.SetInt("Score", score);
    }

    // Set highscore of the player.
    void SetHighScore(int score)
    {
        if (score > PlayerPrefs.GetInt("Highscore"))
        {
            PlayerPrefs.SetInt("Highscore", score);
        }
    }
}
