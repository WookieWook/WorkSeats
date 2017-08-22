using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void SceneChange(string name)
    {
        Debug.Log("Scene change requested " + name);
        SceneManager.LoadScene(name);
    }

    //public void SceneSave() {
      //  Debug.Log("Scene saved");
        //PlayerPrefs.Save();
    //}
}
