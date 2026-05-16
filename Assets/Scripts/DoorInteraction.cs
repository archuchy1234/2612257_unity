using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public float openAngle = 90f;           // outward swing angle
    public float openSpeed = 2f;            // how fast the door moves
    public KeyCode interactKey = KeyCode.H; // choose key in Inspector

    private bool isOpen = false;
    private Quaternion closedRotation;
    private Quaternion openRotation;

    void Start()
    {
        // Save the starting rotation as "closed"
        closedRotation = transform.localRotation;
        // Calculate the "open" rotation (rotate around Y axis)
        openRotation = Quaternion.Euler(transform.localEulerAngles + new Vector3(0, openAngle, 0));
    }

    void Update()
    {
        // Check whichever key you set in Inspector
        if (Input.GetKeyDown(interactKey))
        {
            isOpen = !isOpen; // toggle state
        }

        // Smoothly rotate between closed and open
        transform.localRotation = Quaternion.Slerp(
            transform.localRotation,
            isOpen ? openRotation : closedRotation,
            Time.deltaTime * openSpeed
        );
    }
}
