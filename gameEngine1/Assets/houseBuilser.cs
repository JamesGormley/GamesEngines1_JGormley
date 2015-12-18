using UnityEngine;
using System.Collections;

public class house1 : MonoBehaviour
{


    public GameObject cube1;//instantiate this at runtime
    public int width = 20;
    public int height = 14;
    public int depth = 12;

    // Use this for initialization
    void Start()
    {

        int x = 0, y = 0, z = 0;
        for (z = 0; z < depth + 1; z++)
        {
            for (x = 0; x < width; x++)
            {
                for (y = 0; y < height + 1; y++)
                {
                    GameObject newCube = GameObject.Instantiate(cube1);
                    Vector3 p = new Vector3(x, y, z);
                    newCube.transform.position = p;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}