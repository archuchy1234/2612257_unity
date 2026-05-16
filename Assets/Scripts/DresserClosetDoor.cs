using UnityEngine;

public class DresserClosetDoor : MonoBehaviour
{
    public KeyCode interactKey = KeyCode.J;   // Key to toggle dresser door
    public float openAngle = 90f;             // How far the door swings
    public float openSpeed = 2f;              // Speed of rotation

    private bool isOpen = false;
    private Quaternion closedRotation;
    private Quaternion openRotation;

    void Start()
    {
        // Save the starting rotation
        closedRotation = transform.localRotation;
        // Define the open rotation (rotate around Y axis)
        openRotation = Quaternion.Euler(transform.localEulerAngles + new Vector3(0, openAngle, 0));
    }

    void Update()
    {
        if (Input.GetKeyDown(interactKey))
        {
            isOpen = !isOpen;
        }

        // Smoothly rotate between closed and open
        if (isOpen)
            transform.localRotation = Quaternion.Slerp(transform.localRotation, openRotation, Time.deltaTime * openSpeed);
        else
            transform.localRotation = Quaternion.Slerp(transform.localRotation, closedRotation, Time.deltaTime * openSpeed);
    }
}
