using UnityEngine;

public class LampInteraction : MonoBehaviour
{
    public KeyCode toggleKey = KeyCode.L; // Key to toggle lamp
    private Light lampLight;
    private bool isOn = false; // start OFF

    void Start()
    {
        // Get the Light component attached to this GameObject
        lampLight = GetComponent<Light>();

        if (lampLight == null)
        {
            Debug.LogError("No Light component found on this GameObject!");
            return;
        }

        // Ensure lamp starts OFF
        lampLight.enabled = false;
    }

    void Update()
    {
        if (lampLight == null) return;

        if (Input.GetKeyDown(toggleKey))
        {
            isOn = !isOn;
            lampLight.enabled = isOn; // switch lamp on/off
        }
    }
}
