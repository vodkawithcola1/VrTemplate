using UnityEngine;

public class ReturnToMenu : MonoBehaviour
{
    public GameObject mainMenuUI;
    public GameObject endScreenUI;
    public GameObject pointsUI;
    public GameObject weaponObject;  // Można zostawić puste i szukać po tagu
    

    public void OnReturnToMenuPressed()
    {
        // Pokaż menu
        if (mainMenuUI != null)
            mainMenuUI.SetActive(true);

        // Schowaj ekran końca gry
        if (endScreenUI != null)
            endScreenUI.SetActive(false);

        // Schowaj punkty
        if (pointsUI != null)
            pointsUI.SetActive(false);

        // Usuń broń (jeśli istnieje)
        if (weaponObject != null)
            Destroy(weaponObject);
        else
        {
            GameObject found = GameObject.FindWithTag("Weapon");
            if (found != null)
                Destroy(found);
        }

        // Zatrzymaj spawner i usuń ryby
        Debug.Log("Powrót do menu.");
    }
}