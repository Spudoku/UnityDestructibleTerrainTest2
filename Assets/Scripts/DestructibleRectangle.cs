using UnityEngine;

public class DestructibleRectangle : MonoBehaviour
{
    // min and max size in units
    public static float minSize = 0.0625f;
    public static float defaultSize = 8;
    public static RectangleManager manager;


    PolygonCollider2D coll;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    // {

    //     //coll = BuildCollider(transform.position, defaultSize);

    // }
    public void Initialize()
    {
        Initialize(new());
    }

    void Initialize(Vector2 pos)
    {
        BuildCollider(pos, defaultSize);
    }



    // TODO: communicate with the scene's RectangleManager
    DestructibleRectangle[] Split()
    {
        return null;
    }


    void RemoveRect()
    {
        // delete this object
        Destroy(this);
    }

    // builds a collider given size and
    // initial position
    PolygonCollider2D BuildCollider(Vector2 initPos, float size)
    {
        float x = initPos.x;
        float y = initPos.y;
        Vector2[] points = { new(x + size / 2f, y + size / 2f),
        new(x + size / 2f, y - size / 2f),
        new(x - size / 2f, y - size / 2f),
        new(x - size / 2f, y + size / 2f),};
        return BuildCollider(points);
    }


    // build collider given a list of points
    PolygonCollider2D BuildCollider(Vector2[] points)
    {
        PolygonCollider2D newColl = gameObject.AddComponent<PolygonCollider2D>();
        newColl.points = points;
        return newColl;
    }
}
