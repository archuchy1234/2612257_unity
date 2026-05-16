using UnityEngine;

public class LampInteraction : MonoBehaviour
{
    public KeyCode toggleKey = KeyCode.L; 
    private Light lampLight;
    private bool isOn = false; 

    void Start()
    {
        
        lampLight = GetComponent<Light>();

        if (lampLight == null)
        {
            Debug.LogError("No Light component found on this GameObject!");
            return;
        }

      
        lampLight.enabled = false;
    }

    void Update()
    {
        if (lampLight == null) return;

        if (Input.GetKeyDown(toggleKey))
        {
            isOn = !isOn;
            lampLight.enabled = isOn; 
        }
    }
}
