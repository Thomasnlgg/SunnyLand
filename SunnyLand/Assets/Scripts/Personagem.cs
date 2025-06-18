using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    private string Nome = "Personagem";
    private int vida = 5;
    public float Velocidade = 2.5f;
    private bool iaAlive = true;
    private Rigidbody2D rb;
    public float novagravidade = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Nome: \n" + Nome + "\n Vida: " + vida);
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player")){
            print("yes");
        }
    }
}
