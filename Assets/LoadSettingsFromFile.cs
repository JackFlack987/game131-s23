using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSettingsFromFile : MonoBehaviour
{

    public BounceController bounceController;
  // Set in the inspector
  public BounceController bounceController;
  public TextAsset file;

  // Start is called before the first frame update
  void Start()
  {
    string textContents = file.text;
    string[] lines = textContents.Split(new char[] { '\n', '\r' }, System.StringSplitOptions.RemoveEmptyEntries);

    for (int i = 0; i < lines.Length; i++)
    {
      // TODO: Parse the line into values.
      // Assign those values to the appropriate fields in bounceController.
     
      string line = lines[i];
      string[] words = line.Split(' ');

      string color = words[0];
     
      if (color == "red")
      {
       bounceController.redSpawns = int.Parse(words[1]);
       bounceController.redSpawnRate = float.Parse(words[2]);
       bounceController.redHealth = int.Parse(words[3]);
      }
      if (color == "blue")
      {
        bounceController.blueSpawns = int.Parse(words[1]);
        bounceController.blueSpawnRate = float.Parse(words[2]);
        bounceController.blueHealth = int.Parse(words[3]);
      }

    }
    
  }

  // Update is called once per frame
  void Update()
  {

  }
}
