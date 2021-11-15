using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ObjectMovement : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 kekanan,kekiri,maju,mundur,keatas,kebawah;
    public int aksi ;
    public float speed;
    public int isi_peluru,hp = 100 ,jmlh_hp;
    int score;
    public GameObject ammo;
    void Start()
    {
        kekanan = new Vector3(1,0,0);
        kekiri = new Vector3(-1,0,0);
        maju = new Vector3(0,0,1);
        mundur = new  Vector3(0,0,-1);
        keatas = new Vector3(0,1,0);
        kebawah = new Vector3(0,-1,0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A)){
            transform.position = transform.position + (kekiri * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.S)){
            transform.position = transform.position + (kebawah * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D)){
            transform.position = transform.position + (kekanan * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.W)){
            transform.position = transform.position + (keatas * speed * Time.deltaTime);
        }
        if(Input.GetKey("right")){
            transform.rotation = transform.rotation * Quaternion.Euler(maju * 50 * Time.deltaTime);
        }
        if(Input.GetKey("left")){
            transform.rotation = transform.rotation * Quaternion.Euler(mundur * 50 * Time.deltaTime);
        }
        
        if(Input.GetMouseButton(0)){
            if(isi_peluru > 0 ){
                Instantiate(ammo,transform.position,Quaternion.identity);
                isi_peluru = isi_peluru - 1 ;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D coll){
        
        if ( coll.gameObject.tag == "musuh"){
            hp = hp - 5;
            health.hp = health.hp - 5;
            if ( health.hp == 0){
                Die();
            }
            Debug.Log(hp);  
            
        }
    
        if (coll.gameObject.tag == "koinTag"){
            score++;
            HitungKoin.koin++;
            Debug.Log("koin bertambah : " + score);
        }

    }
    void OnTriggerEnter2D(Collider2D coll) {
         if (coll.gameObject.tag == "peluruTag"){
             isi_peluru ++;
        }   
    }
    void Die(){
        SceneManager.LoadScene("GameOver");
    }
}
    

