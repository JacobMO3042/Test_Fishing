using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class ReturnToObject : MonoBehaviour
{
    public Transform target;// object to return to
    public float speed; //movement per second
    public bool IsReelActive = false; //toggle the return

    public void Activate()
    {
        IsReelActive = true;
    }
    public void Deactive()
    {
        IsReelActive = false;
    }

    void ReelIn()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime); // bring object towards selected object
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IsReelActive){
            ReelIn();
        }


}


}

