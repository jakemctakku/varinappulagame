using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redShrink : MonoBehaviour
{

    public float shrinkSpeed = 5f;

	// Use this for initialization
	void Start ()
    {
        transform.localScale = Vector3.one * 10f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

        if (transform.localScale.x < .01f)
        {
            Destroy(gameObject);
        }
	}
}
