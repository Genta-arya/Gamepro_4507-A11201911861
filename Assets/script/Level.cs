using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Level : MonoBehaviour
{
    // Start is called before the first frame update
    Text jmlhlvl;
    public static  int level=1;
    void Start()
    {
         level = 1;
        jmlhlvl =  GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
         jmlhlvl.text = level.ToString();
    }
}
