using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour {

    public float firstSpeed;
    public float incSpeed;//正数
    public float decSpeed;//負数

    public float moveInputSpeed;//正数
	// Use this for initialization
	void Start () {
        rigidbody.velocity = Vector3.forward*firstSpeed;
	}
	
	// Update is called once per frame
	void Update () {
        MoveContoroll();
	}

    void OnTriggerEnter(Collider other)
    {
        //ダメージ処理
        if (other.tag == "DamageBlock")
        {
            //rigidbody.AddForce(Vector3.forward*decSpeed);
            rigidbody.velocity += Vector3.forward * decSpeed;
        }
        else if(other.tag=="ScoreBlock"){

            //rigidbody.AddForce(Vector3.forward * incSpeed);
            rigidbody.velocity += Vector3.forward * incSpeed;
        }

        //あたったブロック削除
        Destroy(other.transform.parent.gameObject);
    }

    void MoveContoroll()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rigidbody.velocity = new Vector3(horizontal * moveInputSpeed, vertical * moveInputSpeed, rigidbody.velocity.z);
        
    }
}
