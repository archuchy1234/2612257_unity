using UnityEngine;

public class BulbInteraction : MonoBehaviour
{
    public KeyCode toggleKey = KeyCode.B; // key to toggle bulb
    private Light bulbLight;
    private bool isOn = true;

    void Start()
    {
        // Get the Light component attached to this GameObject
        bulbLight = GetComponent<Light>();

        if (bulbLight == null)
        {
            Debug.LogError("No Light component found on this GameObject!");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(toggleKey) && bulbLight != null)
        {
            isOn = !isOn;
            bulbLight.enabled = isOn; // switch light on/off
        }
    }
}
