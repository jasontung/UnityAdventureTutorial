using UnityEngine;

public class BehaviourEnableStateSaver : Saver
{
    public Behaviour behaviorToSave;
    protected override void Load()
    {
        bool enabledState = false;
        if (saveData.Load(key, ref enabledState))
            behaviorToSave.enabled = enabledState;
    }

    protected override void Save()
    {
        saveData.Save(key, behaviorToSave.enabled);
    }

    protected override string SetKey()
    {
        return behaviorToSave.name + behaviorToSave.GetType().FullName + uniqueIdentifier;
    }
}
