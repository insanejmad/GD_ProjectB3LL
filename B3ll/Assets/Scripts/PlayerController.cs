using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    /* Variables publiques = check ton inspector, au niveau du script, tu peux bidouiller les variables comme tu veux ! */
    public float speed = 0.01f;
    public float jumph = 3f;

    private Animator anim;
    private bool isRunning;
    private float jumpTime;
    private bool isFacingRight;
    private bool isCrounched;
    private int Compteur;
    public GameObject[] Profondeurs;
    public GameObject P0;
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    public GameObject P5;

    void Start()
    {
        anim = GetComponent<Animator>();
        isRunning = false;
        jumpTime = 120f;
        isFacingRight = true;
        isCrounched = false;
        Compteur = 1;
        P0 = GameObject.Find("Profondeur-1");
        P1 = GameObject.Find("Profondeur0");
        P2 = GameObject.Find("Profondeur1");
        P3 = GameObject.Find("Profondeur2");
        P4 = GameObject.Find("Profondeur3");
        P5 = GameObject.Find("Profondeur4");
        //Profondeurs.push(P0, P1, P2, P4, P5);

    }

    void Update()
    {
        Vector3 dp = new Vector3();

        // Gérer si le personnage doit être en mode "courrir" ou non
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (isRunning == true)
                isRunning = false;
            else isRunning = true;
        }

        // Gérer si le personnage doit être en mode "accroupi" ou non
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (isCrounched == true)
                isCrounched = false;
            else isCrounched = true;
        }

        // Gérer le déplacement vers la gauche
        if (Input.GetKey(KeyCode.Q))
        {
            if (Input.GetKey(KeyCode.Q))
            {
                dp.x -= speed;
                if (isRunning == true)
                {
                    anim.Play("RunLeft");
                    dp.x *= 2;
                }
                else if (isCrounched == true)
                {
                    anim.Play("CrounchedLeft");
                }
                else { anim.Play("WalkLeft"); }
                isFacingRight = false;
            }
        }

        if (Input.GetKeyUp(KeyCode.Q)) // Ne s'exécute que lorsqu'on arrête d'appuyer sur la touche ! = relâchement donc animation Idle !!
        {
            anim.Play("Idle");
        }

        // Gérer le déplacement vers la droite
        if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.D))
            {
                dp.x += speed;
                if (isRunning == true)
                {
                    anim.Play("RunR");
                    dp.x *= 2;
                }
                else if (isCrounched == true)
                {
                    anim.Play("CrounchedRight");
                }
                else
                {
                    anim.Play("Walk");
                }
                isFacingRight = true;

            }
        }

        if (Input.GetKeyUp(KeyCode.D)) // Ne s'exécute que lorsqu'on arrête d'appuyer sur la touche ! = relâchement donc animation Idle !!
        {
            anim.Play("Idle");
        }

        if (Input.GetKeyDown(KeyCode.Space) && isRunning == true)
        {
            if (isFacingRight == true)
            {
                dp.x += jumph;
                dp.y += jumph;
                anim.Play("JumpR");
            }

            else
            {
                dp.x -= jumph;
                dp.y += jumph;
                anim.Play("JumpLeft");
            }

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.Play("Idle");
        }
    }
}
        /*
        if(Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.D))
        {
            dp.x += jumph;
            anim.Play("JumpR");
        }
        */
        /*if (Input.GetKey(KeyCode.G))
        {
            void DeactivateChildren(GameObject Profondeurs, bool a)
            {
                Profondeurs[Compteur].activeSelf = a;

                foreach (Transform child in Profondeurs[Compteur].transform)
                {
                    DeactivateChildren(child.gameObject, a);
                }
            }
            Compteur = Compteur + 1;
            void DeactivateChildren(GameObject Profondeurs, bool a)
            {
                Profondeurs[Compteur].activeSelf = a;

                foreach (Transform child in Profondeurs[Compteur].transform)
                {
                    DeactivateChildren(child.gameObject, a);
                }
            }
        }

        if (Input.GetKey(KeyCode.B))
        {
            void DeactivateChildren(GameObject Profondeurs, bool a)
            {
                Profondeurs[Compteur].activeSelf = a;

                foreach (Transform child in Profondeurs[Compteur].transform)
                {
                    DeactivateChildren(child.gameObject, a);
                }
            }
            Compteur = Compteur - 1;
            void DeactivateChildren(GameObject Profondeurs, bool a)
            {
                Profondeurs[Compteur].activeSelf = a;

                foreach (Transform child in Profondeurs[Compteur].transform)
                {
                    DeactivateChildren(child.gameObject, a);
                }
            }
        }
            transform.position += dp;
    }
}*/
