using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager inst;

    public event Action<int> EStrengthCrystalPick, EAgilityCrystalPick, EEnduranceCrystalPick;

    private void Awake()
    {
        inst = this;
        DontDestroyOnLoad(this);
    }

    public void StrengthPickInvoke(int value)
    {
        EStrengthCrystalPick?.Invoke(value);
    }
    public void AgilityPickInvoke(int value)
    {
        EAgilityCrystalPick?.Invoke(value);
    }
    public void EndurancePickInvoke(int value)
    {
        EEnduranceCrystalPick?.Invoke(value);
    }
}
