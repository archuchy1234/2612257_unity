using UnityEngine;

public class BulbInteraction : MonoBehaviour
{
    public KeyCode toggleKey = KeyCode.B; 
    private Light bulbLight;
    private bool isOn = true;

    void Start()
    {
        
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
            bulbLight.enabled = isOn; 
        }
    }
}
