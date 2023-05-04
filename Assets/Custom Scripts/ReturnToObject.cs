using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToObject : MonoBehaviour
{
    public Transform target;// object to return to
    public float speed; //movement per second
    public bool Active = false; //toggle the return

    void ActiveReel(bool Active){
        Active = true;
    }
    void DeactiveReel(bool Active){
        Active = false;
    }



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // if(Active = true)
        // {
        //     void ReelIn(){
        //         transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        //     } 
        // }

        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

}


}

