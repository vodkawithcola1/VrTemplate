using UnityEngine;

public class ButtonExit : MonoBehaviour
{
    public void OnExitButtonPressed()
    {
        Debug.Log("Zakoñczono grê przez VR!");
        Application.Quit();
    }
}
