public class FamilyTreeNode {
    public string FullName { get; set; }
    public string Title { get; set; }
    public List<FamilyTreeNode>? Children { get; set; }
    public bool IsRoot { get; set; }

    public FamilyTreeNode(string fullName, string title, bool isRoot)
    {
        Title = title;
        FullName = fullName;
        IsRoot = isRoot;
    }
}