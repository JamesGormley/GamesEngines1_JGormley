using UnityEngine;
using System.Collections;


[RequireComponent(typeof(MeshFilter),typeof(MeshRenderer))]
public class procWall : MonoBehaviour {

    public Mesh mesh;
    public Material material;
    public int width, height;
    private Vector3[] vertices;


    // Use this for initialization
    void Start()
    {
        //gameObject.AddComponent<MeshFilter>().mesh = mesh;
        //gameObject.AddComponent<MeshRenderer>().material = material;

        vertices = new Vector3[(width + 1) * (height + 1)];

       
    }

    private void onDrawGizmos ()
    {
        //check if vertices is empty
        if (vertices == null)
        {
            return;
        }
        Gizmos.color = Color.green;
        //draw dots where vertices meet
        for (int i = 0; i < vertices.Length; i++)
        {
            Gizmos.DrawSphere(vertices[i], 100.1f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
