using UnityEngine;

public class CanvasSingleton : MonoBehaviour
{
    // Static property to hold the reference to the singleton instance
    public static CanvasSingleton Instance { get; private set; }

    private void Awake()
    {
        // Ensure there's only one instance of the singleton
        if (Instance != null && Instance != this)
        {
            // Destroy the duplicate instance
            Destroy(gameObject);
        }
        else
        {
            // Set the singleton instance to this instance
            Instance = this;
        }

        // Ensure the singleton instance persists across scenes
        DontDestroyOnLoad(gameObject);
    }
}