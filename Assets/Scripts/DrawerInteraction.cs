using UnityEngine;

public class DrawerInteraction : MonoBehaviour
{
    public Vector3 openOffset = new Vector3(0, 0, -0.5f); // how far the drawer slides
    public float openSpeed = 2f;                          // how fast it moves
    public KeyCode interactKey = KeyCode.D;               // key to toggle drawer

    private bool isOpen = false;
    private Vector3 closedPosition;
    private Vector3 openPosition;

    void Start()
    {
        // Save the starting position as "closed"
        closedPosition = transform.localPosition;
        // Calculate the "open" position
        openPosition = closedPosition + openOffset;
    }

    void Update()
    {
        if (Input.GetKeyDown(interactKey))
        {
            isOpen = !isOpen; // toggle state
        }

        // Smoothly move between closed and open
        if (isOpen)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, openPosition, Time.deltaTime * openSpeed);
        }
        else
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, closedPosition, Time.deltaTime * openSpeed);
        }
    }
}
