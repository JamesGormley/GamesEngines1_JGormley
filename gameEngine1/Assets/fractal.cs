using UnityEngine;
using System.Collections;

// Procedural shape out of shperes
public class fractal : MonoBehaviour {

    public Mesh mesh;
    public Material material;


    private int depth;
    public int maxDepth;
    public float childScale;


    // Use this for initialization
    void Start () {
        //Attach meshfilter and renderer
        gameObject.AddComponent<MeshFilter>().mesh = mesh;
        gameObject.AddComponent<MeshRenderer>().material = material;
        
        //MaxDepth is height tower will be
        if (depth < maxDepth) {
            new GameObject("Child Sphere Above").AddComponent<fractal>().Initialise(this, Vector3.up);
            new GameObject("Child Sphere Right").AddComponent<fractal>().Initialise(this, Vector3.right);
            new GameObject("Child Sphere Left").AddComponent<fractal>().Initialise(this, Vector3.left);
            new GameObject("Child Sphere Below").AddComponent<fractal>().Initialise(this, Vector3.down);
        }
    }

    private void Initialise (fractal parent, Vector3 side)
    {
        //assign values from parent to child
        mesh = parent.mesh;
        material = parent.material; 
        maxDepth = parent.maxDepth;

        childScale = parent.childScale;
        depth = parent.depth + 1;
        transform.parent = parent.transform;
        //Shrink child by scale 
        transform.localScale = Vector3.one * childScale;
        //Reposition child here. 
        transform.localPosition = side * (0.5f + 0.5f * childScale);
        
    }
	
	// Update is called once per frame
	void Update () {
  
    }

    
}
