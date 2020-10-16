using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALR_CameraMoveForward : MonoBehaviour
{
    public float camSpeed = 1f;
    //public Vector2 camMove;
    



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right.normalized * camSpeed * Time.fixedDeltaTime);

    }
}
