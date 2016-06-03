using UnityEngine;
using System.Collections;

public class SpawnNotes : MonoBehaviour {
    public GameObject[] Notas;
    private float tiempoentrenotas = 0.992f;
	// Use this for initialization
	void Start () {
        StartCoroutine(instanceo(tiempoentrenotas));
    }


    IEnumerator instanceo(float waitTime)
    {
        yield return new WaitForSeconds(4.1f);

        //Parte A
        print("Parte A");
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[3], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[2], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[3], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);

        //Parte B
        print("Parte B");
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[0], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[0], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);

		//Parte A
		print("Parte A");
		Instantiate(Notas[2], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[3], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[2], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[3], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);

		//Parte B
		print("Parte B");
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[0], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[0], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[0], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[0], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);


        //Parte C
        print("Parte C");
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[3], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);


        Instantiate(Notas[3], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[3], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[3], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[0], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[2], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[0], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[2], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(2.2f);

		//Parte A
		print("Parte A");
		Instantiate(Notas[2], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[3], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[2], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[3], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);

		//Parte B
		print("Parte B");
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[0], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[0], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[0], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[0], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);

        //Parte C
        print("Parte C");
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[3], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);


        Instantiate(Notas[3], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[3], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[3], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[2], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[0], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[2], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[0], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(2.5f);

        //Parte T
        print("Parte T1");
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[3], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[3], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        print("Parte T2");
        Instantiate(Notas[3], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[3], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        print("Parte T3");
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[3], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[3], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        print("Parte T4");
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[3], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        print("Parte T5");
        Instantiate(Notas[3], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[3], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        print("Parte T6");
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[3], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        print("Parte T7");
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[3], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[3], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[0], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[3], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(5.5f);

		//Parte A
		print("Parte A");
		Instantiate(Notas[2], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[3], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[2], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[3], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);

		//Parte B
		print("Parte B");
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[0], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[0], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[0], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[0], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);
		Instantiate(Notas[1], transform.position, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);

        //Final
        print("Final");
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[1], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Instantiate(Notas[2], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);


    }

}
