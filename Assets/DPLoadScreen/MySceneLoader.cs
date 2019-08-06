using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneLoader : MonoBehaviour {

    [SerializeField] string sceneName;

// Use this for initialization
	void Start () {
		DPLoadScreen.Instance.LoadLevel(sceneName);
	}

}
