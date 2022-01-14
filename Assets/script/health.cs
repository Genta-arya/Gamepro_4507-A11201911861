using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class health : MonoBehaviour
{
    // Start is called before the first frame update
    Text jmlhdarah;
    public static  int hp;
    void Start()
    {
        hp = 20;
        jmlhdarah =  GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        jmlhdarah.text = hp.ToString();
    }
}
