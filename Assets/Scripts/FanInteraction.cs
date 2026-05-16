using UnityEngine;

public class FanInteraction : MonoBehaviour
{
    public float rotationSpeed = 200f;
    public float pushForce = 10f;
    public KeyCode toggleKey = KeyCode.F;

    private bool isOn = true;

    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            isOn = !isOn;
        }

        if (isOn)
        {
           
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (!isOn) return;

        Rigidbody rb = other.attachedRigidbody;
        if (rb != null)
        {
            rb.AddForce(transform.forward * pushForce, ForceMode.Acceleration);
        }
    }
}
