using UnityEngine;
using System.Collections;

public class ControlNotes : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position + new Vector3(-10, 0, 0) * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "NoteDestructor")
        {
            Destroy(this.gameObject);
        }
    }
}
