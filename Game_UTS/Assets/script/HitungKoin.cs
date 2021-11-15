using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HitungKoin : MonoBehaviour
{
    // Start is called before the first frame update
    Text jmlhkoin;
    public static  int koin;
    void Start()
    {
        koin = 0;
        jmlhkoin = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        jmlhkoin.text = koin.ToString();
    }
}
