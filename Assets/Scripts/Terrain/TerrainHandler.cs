using UnityEngine;

// the "Mastermind" of all terrain.
[RequireComponent(typeof(RectangleManager))]
public class TerrainHandler : MonoBehaviour
{
    [SerializeField] private RectangleManager rm;
    [SerializeField] private Vector2 origin = new();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rm = GetComponent<RectangleManager>();
        rm.tm = this;
        TestRM();
    }

    void TestRM()
    {
        rm.PlaceCollider(origin, Rectangle.DEFAULT_SIZE);
    }

    // // Update is called once per frame
    // void Update()
    // {

    // }
}
