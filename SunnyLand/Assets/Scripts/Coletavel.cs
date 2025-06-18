using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    private int pontos = 5;
    public ParticleSystem efeito;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (outro)
            Debug.Log("bateu");
            collision.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            Instantiate(efeito, transform.position, Quaternion.identity);
            points++;
            texto_pontuacao.text = "Pontos:" + points.ToString();
            Destroy(gameObject);
        }
    }
}
