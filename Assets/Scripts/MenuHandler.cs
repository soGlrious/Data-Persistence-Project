using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuHandler : MonoBehaviour
{

    public TMP_InputField field;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        NewUserInput(field);
        SceneManager.LoadScene(1);
        
    }

    public void NewUserInput(TMP_InputField field)
    {

        DataPersistence.Instance.Username = field;
    }



}
