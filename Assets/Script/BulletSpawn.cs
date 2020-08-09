using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Komponen akan ditambahkan jika tidak ada dan komponen tersebut tidak dapat dibuang
[RequireComponent(typeof(BoxCollider2D))]
public class BulletSpawn : MonoBehaviour
{
    //Global variables
    [SerializeField] private Bird bird;
    [SerializeField] private Bullet bullet;
    
    //Dipanggil setiap frame
    private void Update()
    {
        //Melakukan pengecekan jika pemain menekan space dikeyboard
        if (Input.GetKeyDown("space"))
        {
            //menduplikasi game object Bullet dan menempatkan posisinya sama dengan Bird game object
            Bullet newBullet = Instantiate(bullet, bird.getPosition(), Quaternion.identity);
            //Mengaktifkan game object Bullet
            newBullet.gameObject.SetActive(true);

        }
    }

}