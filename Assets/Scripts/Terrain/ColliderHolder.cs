using UnityEngine;

[RequireComponent(typeof(RectangleManager))]
public class ColliderHolder : MonoBehaviour
{
    static RectangleManager rm;
    // This Component holds and modifies a PolyCollider2D and a Rectangle
    Rectangle rect;
    PolygonCollider2D collider;

    public Vector2 center;

    void Start()
    {
        rm = GetComponent<RectangleManager>();
    }

    // void Update()
    // {

    // }

    void Initialize()
    {
        // instantiate default rect

        collider = gameObject.AddComponent<PolygonCollider2D>();

    }
}
