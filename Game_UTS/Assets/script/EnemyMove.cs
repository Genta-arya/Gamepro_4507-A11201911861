using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 randomArea;
    float randomX;
    float randomY;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       GerakRandom();
    }

    void GerakRandom(){
        randomArea = new Vector2(randomX,randomY);
        transform.position = Vector2.MoveTowards(transform.position,randomArea,4 * Time.deltaTime);
        if (Vector2.Distance(transform.position, randomArea) <= 0){
            randomX = Random.Range(-17.18f,16.59f);
            randomY = Random.Range(-6.75f,6.14f);
        }

    }
    void OnTriggerEnter2D(Collider2D coll) {
         
        if ( coll.gameObject.tag == "ammo"){
            Destroy(gameObject);
        }
     }
}
