using System.Collections;
using System.Collections.Generic;
using UnityEngine;
   
     public class PoliceLightFarol : MonoBehaviour {
     
         public Light RedLight;
         public Light BlueLight;

         public int Number = 1;
		 private float lerp = 1;
		 public Renderer rendRed;
		public Renderer rendBlue;
		 public float duration = 0.1f;

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
                 RedLight.GetComponent<Light>().intensity = 10.5f;
                 StartCoroutine(waitforred());
             }
             if (Number == 2)
             {
                 RedLight.GetComponent<Light>().intensity = 0;
                 BlueLight.GetComponent<Light>().intensity = 10.5f;
                 StartCoroutine(waitforblue());
             }
         }
         private void FixedUpdate() {
            rendRed.material.color = Color.Lerp(Color.white, Color.yellow, lerp);
			rendBlue.material.color = Color.Lerp(Color.yellow, Color.white, lerp);
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
