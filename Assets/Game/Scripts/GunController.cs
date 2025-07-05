using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class GunController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint; // miejsce, z którego leci pocisk
    public float bulletSpeed = 20f;

    private InputAction triggerAction;

    void Start()
    {
        var rightHand = InputSystem.GetDevice<UnityEngine.InputSystem.XR.XRController>(CommonUsages.RightHand);

        if (rightHand != null)
        {
            triggerAction = new InputAction(type: InputActionType.Button, binding: "<XRController>{RightHand}/trigger");
            triggerAction.Enable();
        }
    }

    void Update()
    {
        if (triggerAction != null && triggerAction.triggered)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb)
        {
            rb.velocity = firePoint.forward * bulletSpeed;
        }
    }
}