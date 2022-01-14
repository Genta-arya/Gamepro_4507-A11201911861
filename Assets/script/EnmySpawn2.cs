using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnmySpawn2 : MonoBehaviour
{
   public GameObject enemy;
    public float spawn = 0f;
    public float nextSpawn = 0f;
    public float[] batasPosisi = {6.78f,3.3f,0.84f,-3.06f,-6.66f};
    float randomX;
    int randomY;
    Vector2 posisiSpawn;
    void Update()
    {
        if (Time.time > nextSpawn){
            if(HitungKoin.koin >= 3){
                 randomX = Random.Range(-15.14f,8f);
                randomY = Random.Range(0,batasPosisi.Length);
                posisiSpawn = new Vector2(randomX, batasPosisi[randomY]);
                Instantiate(enemy,posisiSpawn,Quaternion.identity);
                nextSpawn = Time.time + spawn;
                Debug.Log(Time.time + spawn);
            }
           
        }   
        
    }
}
