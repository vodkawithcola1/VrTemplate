using TMPro;
using UnityEngine;

public class ButtonStart : MonoBehaviour
{
    public GameObject weaponPrefab;
    public Transform handTransform;
    public GameObject uiRoot;
    public GameObject points;

    private GameObject currentWeapon;

    public void OnStartButtonPressed()
    {
        Debug.Log("Start gry z przyciskiem VR!");

        if (weaponPrefab != null && handTransform != null)
        {
            currentWeapon = Instantiate(weaponPrefab, handTransform);
            currentWeapon.transform.localPosition = new Vector3(0f, -0.05f, 0.1f);
            currentWeapon.transform.localRotation = Quaternion.Euler(-90f, 0f, 0f);
            points.SetActive(true);
        }

        if (uiRoot != null)
        {
            uiRoot.SetActive(false);
        }
    }
}
