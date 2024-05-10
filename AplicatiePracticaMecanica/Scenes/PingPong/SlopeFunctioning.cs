using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
[RequireComponent(typeof(PolygonCollider2D))]
public class FollowPolygonCollider : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private PolygonCollider2D polygonCollider;
    public float colt1x = 0.255f;
    public float colt1y = 0.255f;
    public float colt2x = 0.255f;
    public float colt2y = -0.615f;
    public float colt3x = 0.255f;
    public float colt3y = 0.255f;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        polygonCollider = GetComponent<PolygonCollider2D>();
    }

    void Update()
    {
        Vector3[] positions = new Vector3[polygonCollider.points.Length];
        for (int i = 0; i < polygonCollider.points.Length; i++)
        {
            positions[i] = transform.TransformPoint(polygonCollider.points[i]);
        }

        lineRenderer.positionCount = positions.Length;
        
        // lineRenderer.SetPosition(0, positions[0] + new Vector3(0.255f , 0.255f, 0));
        // lineRenderer.SetPosition(2, positions[2] + new Vector3(-0.615f, 0.255f, 0));
        // lineRenderer.SetPosition(1, positions[1] + new Vector3(0.255f, -0.615f, 0));

         lineRenderer.SetPosition(0, positions[0] + new Vector3(colt1x, colt1y, 0));
         lineRenderer.SetPosition(1, positions[1] + new Vector3(colt2x, colt2y, 0));
         lineRenderer.SetPosition(2, positions[2] + new Vector3(colt3x, colt3y, 0));
        
    
    }

    

    
}