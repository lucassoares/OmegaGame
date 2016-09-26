﻿using UnityEngine;
using System.Collections;

public class movimentoNave : MonoBehaviour 
{
    public string qualGameOver;
    public static bool morreu;

    void Start()
    {
        morreu = false;
    }

	void Update () 
    {
        if (Input.GetKey(KeyCode.D) && transform.position.x <= 8.16f && escMenu.menuFechado == true) 
        {
            transform.Translate(0.12f, 0, 0);
        }

        if (Input.GetKey(KeyCode.A) && transform.position.x >= -8.4f && escMenu.menuFechado == true)
        {
            transform.Translate(-0.12f, 0, 0);
        }

       if (Input.GetKey(KeyCode.W) && transform.position.y <= 3.8f && escMenu.menuFechado == true)
       {
           transform.Translate(0,0.12f, 0);
       }

       if (Input.GetKey(KeyCode.S) && transform.position.y >= -4.2f && escMenu.menuFechado == true)
       {
           transform.Translate(0, -0.12f, 0);
       }
	}

    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.gameObject.tag == "Finish" || Col.gameObject.tag == "Inimigo" || Col.gameObject.tag == "TiroBoss" || Col.gameObject.tag == "Boss")
        {
            Application.LoadLevel(qualGameOver);
            morreu = true;
        }

    }
}