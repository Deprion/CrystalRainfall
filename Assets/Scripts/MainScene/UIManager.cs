using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button profileBtn, topBtn, backBtn;
    [SerializeField] private GameObject profilePanel, topPanel;
    [SerializeField] private TMP_Text strengthTxt, agilityTxt, enduranceTxt;

    private void Awake()
    {
        profileBtn.onClick.AddListener(delegate { SwitchPanel(profilePanel); });
        topBtn.onClick.AddListener(delegate { SwitchPanel(topPanel); });

        EventManager.inst.EStrengthCrystalPick += UpdateStrength;
        EventManager.inst.EAgilityCrystalPick += UpdateAgility;
        EventManager.inst.EEnduranceCrystalPick += UpdateEndurance;

        UpdateStrength(DataManager.inst.Data.StrengthCrystal);
        UpdateAgility(DataManager.inst.Data.AgilityCrystal);
        UpdateEndurance(DataManager.inst.Data.EnduranceCrystal);
    }

    public void UpdateStrength(int value)
    {
        strengthTxt.text = value.ToString();
    }
    public void UpdateAgility(int value)
    {
        agilityTxt.text = value.ToString();
    }
    public void UpdateEndurance(int value)
    {
        enduranceTxt.text = value.ToString();
    }

    private void SwitchPanel(GameObject go)
    {
        go.SetActive(!go.activeSelf);
        if (go.activeSelf)
        {
            SetBackBtn(go);
        }
        else
        {
            backBtn.gameObject.SetActive(false);
        }
    }
    private void SetBackBtn(GameObject go)
    {
        backBtn.onClick.RemoveAllListeners();
        backBtn.onClick.AddListener(delegate { SwitchPanel(go); });
        backBtn.transform.SetParent(go.transform);
        backBtn.gameObject.SetActive(true);
    }
}
