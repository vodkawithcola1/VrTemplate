using UnityEngine;

public class ButtonExit : MonoBehaviour
{
    public void OnExitButtonPressed()
    {
        Debug.Log("Zako�czono gr� przez VR!");
        Application.Quit();
    }
}
