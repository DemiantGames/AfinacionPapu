using UnityEngine;
using System.Collections;

public class Micro : MonoBehaviour {
	public AudioSource aud;

	public GameObject cube;
	private int minFreq;
	private int maxFreq;

	public float sens = 0.4f;
	public float vol = 0.4f;
	public float loudness;

	public int buffer = 1024;

	private float audioValue = 0f;


	void Start () {
		//Para imprimir los dispositivos de entrada presentes en el sistema
		//En este caso se utiliza null que toma la entrada por defecto del sistema
		/*foreach (string device in Microphone.devices) {
			Debug.Log(Microphone.devices.ToString);
		}*/
		//se obtiene la minima y maxima frecuencia de muestreo soportada por el sistema
		Microphone.GetDeviceCaps(null, out minFreq, out maxFreq);
		//se carga el microfono en un audioclip, se utiliza la minima frecuencia de muestreo para no cargar el sistema
		aud.clip = Microphone.Start (null, true, 10, minFreq);
		//ponemos el audiosource en modo loop
		aud.loop = true;
		//ponemos a reproducir
		while (!(Microphone.GetPosition (null) > 0)) {
		}
		aud.Play ();
	}

	void Update() {
		if(Microphone.IsRecording(null))
		{
			//se obtiene el nivel de la señal y se modifica la posicion en Y del objeto con ese valor
			loudness = GetDataStream()*sens*(vol/10);
			cube.transform.position = new Vector2 (0, 0.1f + loudness);

		}

	}
	//para obtener el valor promedio de la señal por cada bufer de datos
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
