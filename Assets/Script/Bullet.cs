using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Komponen akan ditambahkan jika tidak ada dan komponen tersebut tidak dapat dibuang
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Mencari koponent pipa dari object yang masuk ke area trigger
        Pipe pipa = collision.GetComponent<Pipe>();
        //Pengecekan null variable
        if (pipa)
        {
            //Memusnahkan object pipa ketika bersentuhan
            Destroy(collision.gameObject);
            //Memusnahkan object peluru ketika bersentuhan
            Destroy(this.gameObject);
        }
    }
}
