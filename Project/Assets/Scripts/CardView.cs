using UnityEngine;
using UnityEngine.UI;
using Game.Data;
using TMPro;

namespace Game.View
{
  public class CardView : MonoBehaviour
  {
    [SerializeField] CardModel _cardModel;
    [SerializeField] Image _cardImage;
    [SerializeField] TextMeshProUGUI _priceLabel;
    [SerializeField] Image _progressionImage;
    [SerializeField] Color _filledColor;
    [SerializeField] Color _inProgressColor;
    [SerializeField] TextMeshProUGUI _progression;
    private string valueText;
    private string maxValueText;

    private void Start()
    {
      InitializeView();
    }

    private void InitializeView()
    {
      _cardImage.sprite = _cardModel.CardImage;
      _priceLabel.text = _cardModel.CardPrice.ToString();
      UpdateProgressIndicator();
    }

    private void UpdateProgressIndicator()
    {
      valueText = _cardModel.CurrentProgression.ToString();
      maxValueText = _cardModel.MaxProgression.ToString();
      _progression.text = $"{valueText}/{maxValueText}";

      if (_cardModel.CurrentProgression == _cardModel.MaxProgression)
      {
        _progressionImage.color = _filledColor;
      }
      else
      {
        _progressionImage.color = _inProgressColor;
      }
    }
  }
}
