using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Renderer myRenderer;
    public Color myColor;
    public float myColorR;
    public float myColorG;
    public float myColorB;
    public float myColorA;
    public float speed = 170.0f;
    public float horizontalInput;
    public Vector3 scaleChange = Vector3.one * 0.01f;
    //public float scale = 0.1f;

    void Start()
    {
       // Vector3 orignalScale = transform.localScale; 
        myRenderer = gameObject.GetComponent<Renderer>();
        //Material material = Renderer.material;
        //material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
        //transform.position = new Vector3(3, 4, 1);
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(0.0f, speed * horizontalInput * Time.deltaTime, 0.0f);

        if (Input.GetKey("left"))
        {
            transform.Rotate(0, 5, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, -5, 0);
        }
        // press these keys to change the color
        if (Input.GetKey(KeyCode.A))
        {
            if (myColorA < 1)
            {
                myColorA += 0.1f;
            }
            else
            {
                myColorA = 0;
            }
        }
        if (Input.GetKey(KeyCode.B))
        {
            if (myColorB < 1)
            {
                myColorB += 0.1f;
            }
            else
            {
                myColorB = 0;
            }
        }
        if (Input.GetKey(KeyCode.G))
        {
            if (myColorG < 1)
            {
                myColorG += 0.1f;
            }
            else
            {
                myColorG = 0;
            }
        }
        if (Input.GetKey(KeyCode.R))
        {
            if (myColorR < 1)
            {
                myColorR += 0.1f;
            }
            else
            {
                myColorR = 0;
            }
        }
        myColor = new Color(myColorA, myColorB, myColorG, myColorR);
        myRenderer.material.color = myColor;

    }
    private void FixedUpdate()
    {
        // press key to increase size
        if (Input.GetKey(KeyCode.Space))
        {
            transform.localScale += scaleChange * Time.deltaTime;

        }
        // release key to decrease size
        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.localScale -= scaleChange * Time.deltaTime;
        }

        //if (transform.localScale.x > 2 && transform.localScale.y > 2 && transform.localScale.z > 2)
        //{
        //    transform.localScale -= scaleChange;
        //}
    }
}
