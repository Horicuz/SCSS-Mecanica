using UnityEngine;

public class SpawnDemo : MonoBehaviour
{
    public GameObject itemPrefab; // The prefab of the item to be spawned

    private bool isDragging = false; // Flag to track if an item is being dragged
    private GameObject currentItem; // Reference to the currently dragged item

    private void Update()
    {
        if (isDragging)
        {
            // Update the position of the dragged item based on the mouse position
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            currentItem.transform.position = new Vector3(mousePosition.x, mousePosition.y, 0f);

            // Check if the mouse button is released to stop dragging
            if (Input.GetMouseButtonUp(0))
            {
                isDragging = false;
                currentItem = null;
            }
        }
    }public void SpawnItemUnderParent()
{
    // Find the parent GameObject named "Scena"
    GameObject parent = GameObject.Find("Scena");

    // Ensure that the parent GameObject is found
    if (parent != null)
    {
        // Get the mouse position in screen coordinates
        Vector3 mousePositionScreen = Input.mousePosition;

        // Convert screen coordinates to world coordinates
        Vector3 mousePositionWorld = Camera.main.ScreenToWorldPoint(new Vector3(mousePositionScreen.x, mousePositionScreen.y, Camera.main.nearClipPlane));

        // Adjust the spawn position relative to the parent object's position
        Vector3 spawnPosition = new Vector3(mousePositionWorld.x, mousePositionWorld.y, parent.transform.position.z);

        // Instantiate a new item at the adjusted position under the parent object
        GameObject newItem = Instantiate(itemPrefab, spawnPosition, Quaternion.identity, parent.transform);

        // Set the current item as the newly spawned item
        currentItem = newItem;
        isDragging = true;
    }
    else
    {
        Debug.LogError("Parent GameObject named 'Scena' not found.");
    }
}
}

