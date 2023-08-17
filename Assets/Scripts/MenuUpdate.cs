using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

// MenuUpdate used to populate Best Score data loaded upon start()
public class MenuUpdate : MonoBehaviour
{
    public TextMeshProUGUI userDataText;
    // Start is called before the first frame update
    void Start()
    {
        MainManager.Instance.LoadScore();
        userDataText.text = $"{MainManager.Instance.userName}  {MainManager.Instance.gameScore}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
