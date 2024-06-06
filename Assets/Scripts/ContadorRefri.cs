using TMPro;
using UnityEngine;


public class ContadorRefri : MonoBehaviour
{
    private float _temp;
    private TextMeshProUGUI _textMesh;
    public GameObject dialogo;
    public GameObject img;
    private void Start()
    {
        _temp = 4;
        _textMesh = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        _textMesh.text = _temp.ToString();
        if (_temp == -20)
        {
            dialogo.SetActive(true);
            img.SetActive(true);
            gameObject.GetComponent<ContadorRefri>().enabled = false;
        }
    }

    public void SubirTemp()
    {
        _temp += 1;
    }
    
    public void BajarTemp()
    {
        _temp -= 1;
    }
}

