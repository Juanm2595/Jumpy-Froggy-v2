using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCabeza : MonoBehaviour
{
    public Vida vida;

    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("cabeza");
        if(other.CompareTag("Pies"))
        {   
            AudioManager.Instance.PlaySFX("aplastar");
            Destroy(gameObject);
            vida.efectoRebote(new Vector2(transform.position.x,transform.position.y), transform.localScale.x);
        }
    }
}
