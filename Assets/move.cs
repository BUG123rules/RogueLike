using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class move : MonoBehaviour
{
    public input inp;
    private Rigidbody2D body;

    private bool jumping = false; 

    private float prevY;

    public float moveSpeed;
    public float jumpPower;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void LateUpdate()
    {
       prevY = this.transform.position.y;
    }

    void Update()
    {
        
        if (inp.W && !jumping) 
        {
            body.AddForce(Vector3.up * jumpPower);
        }
        if (inp.A) 
        {
            body.AddForce(new Vector3(-moveSpeed, 0, 0));
        }
        if (inp.D) 
        {
            body.AddForce(new Vector3(moveSpeed, 0, 0));
        }
        

        if (0.01 <= math.abs(prevY - this.transform.position.y)) 
        {
            jumping = true;
        } else {jumping = false;}

    }
}
