using UnityEngine;

public class RotationSaver : Saver
{
    public Transform transformToSave;
    protected override void Load()
    {
        Quaternion rotation = Quaternion.identity;
        if (saveData.Load(key, ref rotation))
            transform.rotation = rotation;
    }

    protected override void Save()
    {
        saveData.Save(key, transformToSave.rotation);
    }

    protected override string SetKey()
    {
        return transformToSave.name + transformToSave.GetType().FullName + uniqueIdentifier;
    }
}
