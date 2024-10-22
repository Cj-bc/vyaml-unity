namespace VYamlUnity

public abstract class UnityComponent
{
    public readonly int FileID;
    public UnityComponent(int _fileID)
    {
	FileID = _fileID;
    }
}

public UnityTransform : UnityComponent
{
    public Vector3 Position;
    public Vector3 Scale;
    public UnityTransform? Parent;
}

public class UnityGameObject : UnityComponent
{
    public List<UnityComponent> AttachedComponents;
    public string Name;

    public UnityGameObject(int _fileID, string _name, List<UnityComponent> components) : base(_fileID)
    {
	Name = _name;
    }
}

public readonly record struct GUIDReference(string Guid, int FileId);

public class UnityMonobehaviour : UnityComponent
{
    public GUIDReference Script;
}

public abstract class AssetFile
{
    public string Path;
    public string Guid;

    public abstract string ResolveFileID(int fileID);
}

public class SceneFile : AssetFile
{
    public List<UnityGameObject> GameObjects;
    public Dictionary<string, UnityGameObject> 

    private void AddGameObject(UnityGameObject go)
    {
    }

    public UnityGameObject? GetGameObject(int fileID);
    public UnityGameObject? GetGameObject(UnityComponent component)
    {
    }
	
}
