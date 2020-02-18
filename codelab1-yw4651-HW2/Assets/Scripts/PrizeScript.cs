using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizeScript : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.GetComponent<SpriteRenderer>().color != Color.red)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;

            gameObject.GetComponent<generateNewPrize>();

        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.black;
        }

    }
}

