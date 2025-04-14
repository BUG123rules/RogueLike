using UnityEngine;

public class input : MonoBehaviour
{
    public bool W;
    public bool A;
    public bool S;
    public bool D;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            W = true;
        } else {W = false;}

        if (Input.GetKey(KeyCode.A)) 
        {
            A = true;
        } else {A = false;}

        if (Input.GetKey(KeyCode.S)) 
        {
            S = true;
        } else {S = false;}

        if (Input.GetKey(KeyCode.D)) 
        {
            D = true;
        } else {D = false;}        
    }
}
