using System.Collections.Generic;
using UnityEngine;
// handles all DestructibleRectangles in the Scene
[CreateAssetMenu(fileName = "RectangleManager", menuName = "Scriptable Objects/RectangleManager")]
public class RectangleManager : ScriptableObject
{
    List<DestructibleRectangle> allRects;


    void PlaceRectangle(Vector2 pos)
    {
        PlaceRectangle(pos, DestructibleRectangle.defaultSize);
    }

    void PlaceRectangle(Vector2 pos, float size)
    {
        // somehow create and place Destructible
    }


}
