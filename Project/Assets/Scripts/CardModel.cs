using UnityEngine;

namespace Game.Data
{
  [CreateAssetMenu(fileName = "New Card Model", menuName = "Create Card Model")]
  public class CardModel : ScriptableObject
  {
    [SerializeField] private string _cardName;
    [SerializeField] private int _cardPrice;
    [SerializeField] private int _maxProgression;
    [SerializeField] private int _currentProgression;
    [SerializeField] private Sprite _cardImage;

    public string CardName => _cardName;
    public int CardPrice => _cardPrice;
    public int MaxProgression => _maxProgression;
    public int CurrentProgression
    {
      get => _currentProgression;
      set => _currentProgression = Mathf.Min(value, _maxProgression);
    }
    public Sprite CardImage => _cardImage;

    private void OnValidate()
    {
      _currentProgression = Mathf.Min(_currentProgression, _maxProgression);
    }
  }
}
