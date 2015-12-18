using UnityEngine;
using System.Collections;

//This script drops boxes in random locations within public limits
public class path : MonoBehaviour {

    public GameObject cube;
    public int numberBoxes;
    public int min, max;
    // Use this for initialization
    void Start () {
        putBoxes();
	}

    //Method to drop boxes
    void putBoxes()
    {
        for (int i = 0; i < numberBoxes; i++ )
        {
            //put box at random position
            Instantiate(cube, RandomPos(), Quaternion.identity);
        }
    }
    // make random vectors for putBoxes method. Return vector3 for location
    Vector3 RandomPos()
    {
        int x, y, z;
        // Limits boxes will be dropped within. Extend x and limit y to fit in building
        x = UnityEngine.Random.Range(min, max + 20);
        y = UnityEngine.Random.Range(min, 15);
        z = UnityEngine.Random.Range(min, max);
        return new Vector3(x, y, z);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
