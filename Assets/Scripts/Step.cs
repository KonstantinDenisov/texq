using UnityEngine;
using UnityEngine.UI;

public class Step : MonoBehaviour
{
  #region Varibles

  public string DebugHeaderText;
  [TextArea(4,8)] 
  public string DescriptionText;
  [TextArea(4,6)] 
  public string ChoicesText;
  public string LocationName;
  public Sprite LocationImage;

  public Step[] Choices;

  #endregion

}