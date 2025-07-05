using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHP = 100f;
    private float currentHP;

    void Start()
    {
        currentHP = maxHP;
    }

    public void TakeDamage(float amount)
    {
        currentHP -= amount;
        Debug.Log($"Gracz dostał {amount} DMG. HP: {currentHP}/{maxHP}");

        if (currentHP <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Gracz zginął.");
        if (ScoreManager.instance != null)
        {
            ScoreManager.instance.EndGame();
        }

        // np. zablokuj ruch, strzelanie itd.
        
    }
    public void ResetHP()
    {
        currentHP = maxHP;
    }
}