using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarsAuRegime : MonoBehaviour
{
    // Start is called before the first frame update
    public float horizontalSpeed = 100f;
    public float verticalSpeed = 10f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float translationX = Input.GetAxis("Horizontal") * horizontalSpeed;
        float translationY = Input.GetAxis("Vertical") * verticalSpeed;

        translationX *= Time.deltaTime;
        translationY *= Time.deltaTime;

        Debug.Log(translationX);
        
    }
}
