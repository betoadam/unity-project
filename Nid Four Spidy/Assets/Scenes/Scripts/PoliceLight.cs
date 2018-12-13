using System.Collections;
using System.Collections.Generic;
using UnityEngine;
   
     public class PoliceLight : MonoBehaviour {
     
         public Light RedLight;
         public Light BlueLight;

         public int Number = 1;
		 private float lerp = 1;
		 public Renderer rendRed;
		public Renderer rendBlue;
		 public float duration = 0.01f;
         private Color azul;
         private Color vermelho;
         // Use this for initialization
         void Start () 
         {
             Number = 1;
             BlueLight.GetComponent<Light>().intensity = 0;
             RedLight.GetComponent<Light>().intensity = 0;
         }
         
         // Update is called once per frame
         void Update () 
         {
			
             if (Number == 1)
             {
                 BlueLight.GetComponent<Light>().intensity = 0;
                 RedLight.GetComponent<Light>().intensity = 100.5f;
                 StartCoroutine(waitforred());
             }
             if (Number == 2)
             {
                 RedLight.GetComponent<Light>().intensity = 0;
                 BlueLight.GetComponent<Light>().intensity = 100.5f;
                 StartCoroutine(waitforblue());
             }
         }
         private void FixedUpdate() {
            RedLight.transform.Rotate(Vector3.up * Time.deltaTime*3000, Space.World);
            BlueLight.transform.Rotate(Vector3.up * Time.deltaTime*3000, Space.World);
            rendRed.material.color = Color.Lerp(Color.red, Color.yellow, lerp);
			rendBlue.material.color = Color.Lerp(Color.yellow, Color.blue, lerp);
            lerp = Mathf.PingPong(Time.time,duration)/duration;
         }
         IEnumerator waitforred()
         {
             yield return new WaitForSeconds (0.2f);
             Number = 2;
         }
         IEnumerator waitforblue()
         {
             yield return new WaitForSeconds (0.2f);
             Number = 1;
         }
     }
