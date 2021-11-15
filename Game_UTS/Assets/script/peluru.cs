using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peluru : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 dir;
    void Start()
    {
        dir = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,dir,20*Time.deltaTime);
        if(Vector2.Distance(transform.position,dir) <= 0){
            Destroy(gameObject);        
        }
    }
}
