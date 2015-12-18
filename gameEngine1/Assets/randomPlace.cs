using UnityEngine;
using System.Collections;
using System;

// ***** NOT RANDOM ***** Places items on points of circle of radius R
public class randomPlace : MonoBehaviour {

    public GameObject structure;
    public int radius, numPlaces, centerX, centerZ;

	// Use this for initialization
	void Start () {
       
        putTowers( numPlaces, radius, centerX, centerZ);
    }

    void putTowers(int numPlaces, float radius, int centerX, int centerZ)
    {

        //Get angle needed for number of places 
        double angle = 2 * Math.PI / numPlaces;
        //i * angle will split circle 
        for (int i = 0; i < numPlaces; i++)
        {
            //multiply by i to increase angle
            double angle2 = angle * i;
            int newX = (int)(centerX + radius * Math.Cos(angle2));
            int newZ = (int)(centerZ + radius * Math.Sin(angle2));

            //instantiate and pass in new coords
            GameObject tower = GameObject.Instantiate(structure);
            Vector3 p = new Vector3(newX, 10, newZ);
            tower.transform.position = p;
       
        }
    }
   
}
