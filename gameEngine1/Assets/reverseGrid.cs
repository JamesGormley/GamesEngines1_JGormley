using UnityEngine;
using System.Collections;

// Mesh wall, displays on opposite side to mesh wall in grid
[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class reverseGrid : MonoBehaviour
{

    public int width, height;
    private Vector3[] vertices;
    private Mesh mesh;

    //Populate our array of vertices. Width & Height + 1
    private void Generate()
    {

        GetComponent<MeshFilter>().mesh = mesh = new Mesh();
        mesh.name = "Procedural reverseGrid";

        vertices = new Vector3[(width + 1) * (height + 1)];
        Vector2[] uv = new Vector2[vertices.Length];
        //DOuble loop to position vertices
        for (int i = 0, y = 0; y <= height; y++)
        {
            for (int x = 0; x <= width; x++, i++)
            {
                vertices[i] = new Vector3(x, y);
                uv[i] = new Vector2((float)x / width, (float)y / height);
            }
        }
        mesh.vertices = vertices;
        mesh.uv = uv;

        //create and populate triangles array
        int[] triangles = new int[width * height * 6];
        for (int tri = 0, ver = 0, y = 0; y<height; y++, ver++)
        {
            for (int x = 0; x<width; x++, tri += 6, ver++)
            {
                //reverse order of vertices to display on other side
                triangles[tri] = ver;
                triangles[tri + 1] = triangles[tri + 3] = ver + 1;
                triangles[tri + 2] = triangles[tri + 5] = ver + width + 1;
                triangles[tri + 4] = ver + width + 2;
            }
        }
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }


 

//Awake is called when the script instance is being loaded
private void Awake()
    {
        Generate();
    }

}
