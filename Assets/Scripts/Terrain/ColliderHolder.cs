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

    public void Initialize()
    {
        Initialize(new(), Rectangle.DEFAULT_SIZE);
    }



    public void Initialize(Vector2 middle)
    {
        Initialize(middle, Rectangle.DEFAULT_SIZE);
    }

    public void Initialize(Vector2 middle, float size)
    {
        center = middle;
        rect = new Rectangle(center, size);
        collider = gameObject.AddComponent<PolygonCollider2D>();
        collider.points = rect.vertices;
    }
}
