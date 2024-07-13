using UnityEngine;
using UnityEngine.Events;

public class ClickableObject : MonoBehaviour
{
    [SerializeField] private Outline _outline;
    [SerializeField] private bool _isSelected = false;

    public UnityEvent OnClick = new UnityEvent();
    public bool IsSelected => _isSelected;

    private void Awake()
    {
        _outline = GetComponent<Outline>();
        if (_outline == null)
        {
            Debug.LogError("Outline component is missing!");
        }
    }

    public void OnMouseOver()
    {
        _outline.enabled = true;
    }

    public void OnMouseExit()
    {
        if (_isSelected == false)
        {
            _outline.enabled = false;
        }
        
    }

    public void OnMouseDown()
    {
        //SelectionManager.Instance.SelectObject(this);
        _isSelected = !_isSelected;
        _outline.enabled = !_outline.enabled;

        OnClick?.Invoke();
    }

    public void Selected(bool isSelected)
    {
        _isSelected = isSelected;
        _outline.enabled = _isSelected;
    }

}
