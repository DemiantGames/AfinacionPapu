using UnityEngine;
using System.Collections;

public class RobotTestScriptFree : MonoBehaviour {

	private Animator anim;
	private float jumpTimer = 0;
	private bool jumpflag=true;
	private float TiempoSalto=8;

	public AudioSource aud;
	private int minFreq;
	private int maxFreq;
	public float sens = 0.4f;
	public float vol = 0.4f;
	public float loudness;
	public int buffer = 1024;
	private float audioValue = 0f;

	void Start () {
		Microphone.GetDeviceCaps(null, out minFreq, out maxFreq);
		//se carga el microfono en un audioclip, se utiliza la minima frecuencia de muestreo para no cargar el sistema
		aud.clip = Microphone.Start (null, true, 10, minFreq);
		//ponemos el audiosource en modo loop
		aud.loop = true;
		//ponemos a reproducir
		while (!(Microphone.GetPosition (null) > 0)) {
		}
		aud.Play ();

		anim = this.gameObject.GetComponent<Animator> ();
		anim.SetInteger ("Speed", 2);
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Microphone.IsRecording(null))
		{
			//se obtiene el nivel de la señal y se modifica la posicion en Y del objeto con ese valor
			loudness = GetDataStream()*sens*(vol/10);

		}
			



		if (TiempoSalto<=0) {
			transform.position =  new Vector3 (transform.position.x,loudness*5000,transform.position.z);

				TiempoSalto = 1;
			}

			
		TiempoSalto-=Time.deltaTime;

	

	}


	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Piso")
		{
			anim.SetBool ("Jumping", false);
		}
	}
	void OnCollisionExit(Collision collision) {
		if (collision.gameObject.tag == "Piso")
		{
			anim.SetBool ("Jumping", true);
		}
	}




	float GetDataStream(){
		float returnedvalue = 1;
		audioValue = 0;
		if (Microphone.IsRecording (null)) {
			float[] dataStream = new float[buffer];


			aud.GetOutputData (dataStream, 0);

			foreach (float i in dataStream) {
				audioValue += Mathf.Abs (i);
			}

			return audioValue / buffer;
		} else {
			return returnedvalue;
		}
	}

}
