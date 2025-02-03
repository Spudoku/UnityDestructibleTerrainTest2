using UnityEngine;

public class DestructibleRectangle : MonoBehaviour
{
    // min and max size in units
    public static float minSize = 0.025f;
    public static float defaultSize = 32;

    Vector2[] vertices;

    PolygonCollider2D coll;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coll = null;

    }

    // Update is called once per frame
    // void Update()
    // {

    // }

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
    void BuildCollider(Vector2 initPos, float size)
    {
        float x = initPos.x;
        float y = initPos.y;
        Vector2[] points = { new(x + size / 2f, y + size / 2f) };
    }


    // build collider given a list of points
    void BuildCollider(Vector2[] points)
    {

    }
}
