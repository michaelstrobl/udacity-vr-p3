using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    public GameObject KeyPoofPrefab;
    public Door Door;

    void Update()
    {
        //Bonus: Key Animation
    }

    public void OnKeyClicked()
    {
        Instantiate (KeyPoofPrefab, transform.position, Quaternion.Euler(-90, 0, 0));
        Destroy (this.gameObject);
        Door.Unlock ();
    }

}
