using UnityEngine;

public class FishHealth : MonoBehaviour
{
    public float maxHP = 100f;
    private float currentHP;

    // Ile punktów dodaje ta ryba po jej zniszczeniu
    public int scoreValue = 10;

    void Start()
    {
        currentHP = maxHP;
    }

    public void TakeDamage(float damage)
    {
        currentHP -= damage;
        Debug.Log($"{gameObject.name} dostał {damage} obrażeń. HP: {currentHP}/{maxHP}");

        if (currentHP <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log($"{gameObject.name} umarł.");

        // Dodaj punkty do wyniku
        if (ScoreManager.instance != null)
        {
            ScoreManager.instance.AddScore(scoreValue);

        }

        Destroy(gameObject);  // usuwa obiekt ryby
    }
}