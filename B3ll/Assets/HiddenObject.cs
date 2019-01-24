using UnityEngine;

public class HiddenObject : MonoBehaviour
{
    public GameObject GoingToProf;                            //Référence à la plateforme
    public GameObject FromProf;

    void Start()
    {
    }

    void OnTriggerEnter2D(Collider2D joueur)
    {
        if (joueur.name == "Player")
        {
            Debug.Log("Je passe sur la porte");
            GoingToProf.SetActive(true);      //Activation de la plateforme
            FromProf.SetActive(false);
        }

        /*
        Debug.Log("prout");
        //Si le tag du gameObject du collider touché est égale à "Player"
        if (col.name == "Player")
        {
            Debug.Log("Je passe sur la porte");
            GoingToProf.SetActiveRecursively(true);      //Activation de la plateforme
            FromProf.SetActiveRecursively(false);
        }

    */
    }
}
