using UnityEngine;
using System.Collections;
using UnityEditor.ShaderGraph.Internal;
public class Rectangle
{
    // min and maxdefaultSize in units
    public static float minSize = 0.0625f;
    public const float DEFAULT_SIZE = 4;
    public static RectangleManager manager;

    public Vector2[] vertices;

    // Constructors
    public Rectangle() : this(new Vector2(), DEFAULT_SIZE) { }

    public Rectangle(Vector2 initPos) : this(initPos, DEFAULT_SIZE) { }

    public Rectangle(Vector2 initPos, float size)
    {
        // make sure rectangles are never larger than defaultSize
        float testSize = size;
        if (testSize > DEFAULT_SIZE)
        {
            testSize = DEFAULT_SIZE;
        }
        float x = initPos.x;
        float y = initPos.y;
        vertices = new Vector2[] { new(x + testSize / 2f, y + testSize / 2f),
                new(x + testSize / 2f, y - testSize / 2f),
                new(x - testSize / 2f, y - testSize / 2f),
                new(x - testSize / 2f, y + testSize / 2f),};

    }

}
//     {
//         float x = initPos.x;
//         float y = initPos.y;
//         Vector2[] points = { new(x +defaultSize / 2f, y +defaultSize / 2f),
//         new(x +defaultSize / 2f, y -defaultSize / 2f),
//         new(x -defaultSize / 2f, y -defaultSize / 2f),
//         new(x -defaultSize / 2f, y +defaultSize / 2f),};
//         return BuildCollider(points);
//     }

//     using UnityEngine;

// public class DestructibleRectangle : MonoBehaviour
// {
//     // min and maxdefaultSize in units
//     public static float minSize = 0.0625f;
//     public static float defaultSize = 8;
//     public static RectangleManager manager;


//     PolygonCollider2D coll;
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     // void Start()
//     // {

//     //     //coll = BuildCollider(transform.position, defaultSize);

//     // }
//     public void Initialize()
//     {
//         Initialize(new());
//     }

//     void Initialize(Vector2 pos)
//     {
//         BuildCollider(pos, defaultSize);
//     }



//     // TODO: communicate with the scene's RectangleManager
//     DestructibleRectangle[] Split()
//     {
//         return null;
//     }


//     void RemoveRect()
//     {
//         // delete this object
//         Destroy(this);
//     }

//     // builds a collider givendefaultSize and
//     // initial position
//     PolygonCollider2D BuildCollider(Vector2 initPos, floatdefaultSize)
//     {
//         float x = initPos.x;
//         float y = initPos.y;
//         Vector2[] points = { new(x +defaultSize / 2f, y +defaultSize / 2f),
//         new(x +defaultSize / 2f, y -defaultSize / 2f),
//         new(x -defaultSize / 2f, y -defaultSize / 2f),
//         new(x -defaultSize / 2f, y +defaultSize / 2f),};
//         return BuildCollider(points);
//     }


//     // build collider given a list of points
//     PolygonCollider2D BuildCollider(Vector2[] points)
//     {
//         PolygonCollider2D newColl = gameObject.AddComponent<PolygonCollider2D>();
//         newColl.points = points;
//         return newColl;
//     }
// }