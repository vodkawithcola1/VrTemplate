using UnityEngine;

public class bullet : MonoBehaviour
{
    public float damage = 25f;
    public float lifeTime = 5f;

    void Start()
    {
        Destroy(gameObject, lifeTime);  // niszczy pocisk po 5 sekundach, jeśli nie trafi
    }

    private void OnTriggerEnter(Collider other)
    {
        FishHealth ryba = other.GetComponent<FishHealth>();
        if (ryba != null)
        {
            ryba.TakeDamage(damage);
            Destroy(gameObject);  // niszczy pocisk po trafieniu
        }
    }
}