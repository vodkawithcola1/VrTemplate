using System;
using TMPro;
using UnityEngine;

public class ButtonStart : MonoBehaviour
{
    public GameObject weapon; // ← nie prefab, tylko gotowy obiekt z hierarchy!
    public GameObject uiRoot;
    public GameObject points;
    public FishSpawner fishSpawner;
    public GameObject menurock;
    public PlayerHealth playerHealth;

    public void OnStartButtonPressed()
    {
        fishSpawner.StartSpawning();
        Debug.Log("Start gry z przyciskiem VR!");

        if (weapon != null)
        {
            weapon.SetActive(true); // ← zamiast Instantiate
        }

        if (points != null)
        {
            points.SetActive(true);
        }

        if (uiRoot != null)
        {
            uiRoot.SetActive(false);
        }

        if (menurock!=null)
        {
            menurock.SetActive(false);
        }
        ScoreManager.instance.score = 0;
        ScoreManager.instance.scoreText.text = "Points: 0";
        playerHealth.ResetHP();
        
    }
}