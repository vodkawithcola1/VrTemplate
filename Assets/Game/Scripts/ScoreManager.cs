using UnityEngine;
using TMPro; // ← TO JEST WAŻNE!

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score = 0;
    public TextMeshPro scoreText;  // ← zamiast zwykłego Text
    
    public GameObject endScreenUI;
    public TextMeshPro finalScoreText;
    public GameObject weapon;
    public GameObject points;
    public GameObject menurock;
    public GameObject finalScore;

    private int totalFish = 0;
    private int deadFish = 0;
    public FishSpawner fishSpawner;

    void Awake()
    {
        
        // Singleton
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        scoreText.text = "Points: " + score;
    }

    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Aktualny wynik: " + score);

        if (scoreText != null)
        {
            scoreText.text = "Points: " + score;
        }
    }
    

    public void EndGame()
    {
        if (endScreenUI != null) endScreenUI.SetActive(true);
        if (finalScoreText != null) finalScoreText.text = "Points: " + score;
        if (weapon != null) weapon.SetActive(false);  
        if (points != null) points.SetActive(false);  
        if (menurock != null) menurock.SetActive(true);  
        if (finalScore != null) finalScore.SetActive(true);  
        if (fishSpawner != null)
        {
            fishSpawner.StopSpawning();       
            fishSpawner.DestroyAllFish();     
        }
    }

}