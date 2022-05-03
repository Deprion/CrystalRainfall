using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private RainfallManager rainfall;
    public static GameManager inst;

    private void Awake()
    {
        inst = this;
        rainfall = GetComponent<RainfallManager>();
        rainfall.StartRainfall();
    }
    public void ObjectClicked(Item item)
    {
        if (item.TypeOfItem == Global.TypeOfItem.Trash) return;

        var crystal = (Crystal)item;

        switch (crystal.TypeOfCrystal)
        {
            case Global.TypeOfCrystal.Strength:
                EventManager.inst.StrengthPickInvoke(++DataManager.inst.Data.StrengthCrystal);
                break;
            case Global.TypeOfCrystal.Agility:
                EventManager.inst.AgilityPickInvoke(++DataManager.inst.Data.AgilityCrystal);
                break;
            case Global.TypeOfCrystal.Endurance:
                EventManager.inst.EndurancePickInvoke(++DataManager.inst.Data.EnduranceCrystal);
                break;
        }
    }
}
