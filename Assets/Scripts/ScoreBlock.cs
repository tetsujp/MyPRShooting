using UnityEngine;
using System.Collections;

public class ScoreBlock : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    private void OnTriggerEnter(Collider other)
    {
        //プレイヤーへの接触
        if (other.tag == "PlayerCharacter")
        {

        }
    }
}
