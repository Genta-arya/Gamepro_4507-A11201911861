using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Enmy : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    [SerializeField] float ms;
    void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,player.transform.position,Time.deltaTime * ms);
    }
}
