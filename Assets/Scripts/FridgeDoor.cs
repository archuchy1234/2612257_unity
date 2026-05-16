using UnityEngine;

public class FridgeDoor : MonoBehaviour
{
    public float openAngle = -100f;      // how far the fridge door swings
    public float openSpeed = 2f;         // how fast the door moves
    public KeyCode interactKey = KeyCode.R; // key to toggle fridge door

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
        if (Input.GetKeyDown(interactKey))
        {
            isOpen = !isOpen; // toggle state
        }

        // Smoothly rotate between closed and open
        if (isOpen)
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, openRotation, Time.deltaTime * openSpeed);
        }
        else
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, closedRotation, Time.deltaTime * openSpeed);
        }
    }
}
