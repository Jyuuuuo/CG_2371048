using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class S03_ : MonoBehaviour
{
    void Start()
    {
        Vector3[] vertices = new Vector3[]
        {
              new Vector3(0f, 1f, 0f), // 0
              new Vector3(1f, 0f, 0f), // 1
              new Vector3(2f, 1f, 0f), // 2
              new Vector3(2f, 2f, 0f), // 3
              new Vector3(1f, 3f, 0f), // 4
              new Vector3(0f, 2f, 0f), // 5

        };
        int[] triangles = new int[]
        {
            0, 1, 2,
            2, 3, 5,
            3, 4, 5,
            0, 2, 5
        };


        Mesh mesh = new Mesh();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();

        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().sharedMaterial = new Material(Shader.Find("Universal Render Pipeline/Lit"));
    }
}
