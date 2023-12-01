using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public bool enableDebug = false;


public class Template : MonoBehaviour
{
  void Start() //What happens at the start of entering playmode
  {
         DebugMessage("start has happened");   
  }


  void Update() // What happens every frame
  {
          DebugMessage("New Frame has happened");    
  }



  public void DebugMessage (string theMessage) // This logic will only happen if the local debug is enabled
  {
    if (enableDebug)
      {
        Debug.Log(theMessage);
      }
  }

}
