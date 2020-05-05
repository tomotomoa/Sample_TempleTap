using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MokugyoManager : MonoBehaviour
{

    //オブジェクト参照
    public GameObject gameManager; //ゲームマネージャー

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TapMokugyo () {
        Debug.Log("touch");
        gameManager.GetComponent<GameManager> ().CreateNewOrb ();
    }
}
