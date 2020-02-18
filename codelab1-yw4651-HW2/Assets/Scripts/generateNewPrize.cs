using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateNewPrize : MonoBehaviour
{
    Transform newPrizeLocation;  //the location of new prize 
    public GameObject OriginPrize;     // all the prize should look like this
    public GameObject whatToClone;    // what used to clone as a new prize
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void CloneNewPrize() {

        whatToClone = Instantiate(OriginPrize, newPrizeLocation.transform.position, Quaternion.Euler(0, 0, 0)); 

        newPrizeLocation.transform.position = new Vector2(Random.Range(-4, 4), Random.Range(-4, 4)); 

    }
   
}
