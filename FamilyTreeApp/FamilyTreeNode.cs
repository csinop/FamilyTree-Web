public class FamilyTreeNode
{
    private Guid _nodeID;
    public string FullName { get; set; }
    public string Title { get; set; }
    public List<FamilyTreeNode> Children { get; set; }
    public bool IsRoot { get; set; }

    public FamilyTreeNode(string fullName, string title, bool isRoot)
    {
        Title = title;
        FullName = fullName;
        IsRoot = isRoot;

        Children = [];

        _nodeID = new Guid();
    }

    public Guid GetNodeID()
    {
        return _nodeID;
    }
}