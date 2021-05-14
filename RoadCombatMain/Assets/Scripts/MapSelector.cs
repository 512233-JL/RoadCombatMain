using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MapSelector : MonoBehaviour
{
    [SerializeField]private Button previousButton;
    [SerializeField]private Button nextButton;
    private int currentMap;

    private void Awake()
    {
        SelectedMap(0);
    }
   private void SelectedMap(int _index)
   {
       previousButton.interactable = (_index != 0);
       nextButton.interactable = (_index != transform.childCount-1);
       for(int i=0;i<transform.childCount; i++)
       {
           transform.GetChild(i).gameObject.SetActive(i==_index);
       }
   }

   public void ChangeMap(int _change)
   {
       currentMap += _change;
       SelectedMap(currentMap);
   }

   public void StartGame() {
       
    if (currentMap == 0){
    SceneManager.LoadScene("CityScene");
    }

    if (currentMap == 1) {
    SceneManager.LoadScene("AirportScene");
    }

    if (currentMap == 2) {
    SceneManager.LoadScene("BeachScene");
    }
   }
   

}
