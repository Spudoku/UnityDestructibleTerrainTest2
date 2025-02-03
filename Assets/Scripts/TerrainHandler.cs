using UnityEngine;

// the "Mastermind" of all terrain.
public class TerrainHandler : MonoBehaviour
{
    [SerializeField]
    private RectangleManager rm;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rm = ScriptableObject.CreateInstance<RectangleManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
