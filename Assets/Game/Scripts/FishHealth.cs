using UnityEngine;

public class FishHealth : MonoBehaviour
{
    public float maxHP = 100f;
    private float currentHP;

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
        Destroy(gameObject);  // niszczy obiekt ryby
    }
}