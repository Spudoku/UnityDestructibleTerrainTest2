using System.Collections.Generic;
using UnityEngine;
// handles all DestructibleRectangles in the Scene
//[CreateAssetMenu(fileName = "RectangleManager", menuName = "Scriptable Objects/RectangleManager")]
public class RectangleManager : MonoBehaviour
{
    public TerrainHandler tm;
    public List<ColliderHolder> colliders;



    public void PlaceCollider(Vector2 location, float size)
    {
        ColliderHolder newCollider = gameObject.AddComponent<ColliderHolder>();
        newCollider.Initialize(location, size);
        colliders.Add(newCollider);
    }
}
