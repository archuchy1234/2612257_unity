using UnityEngine;

public class StoveDrawer : MonoBehaviour
{
    public float openDistance = 0.5f;   // how far it moves down
    public float openSpeed = 2f;        // how fast it moves
    private bool isOpen = false;
    private Vector3 closedPosition;
    private Vector3 openPosition;

    void Start()
    {
        // Save starting position
        closedPosition = transform.localPosition;
        // Define open position (downwards on Y axis)
        openPosition = closedPosition + new Vector3(0, -openDistance, 0);
    }

    void Update()
    {
        // Toggle when pressing O
        if (Input.GetKeyDown(KeyCode.O))
        {
            isOpen = !isOpen;
        }

        // Smoothly move between positions
        transform.localPosition = Vector3.Lerp(
            transform.localPosition,
            isOpen ? openPosition : closedPosition,
            Time.deltaTime * openSpeed
        );
    }
}
