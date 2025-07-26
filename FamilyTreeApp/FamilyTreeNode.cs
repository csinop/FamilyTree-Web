public class FamilyTreeNode
{
    public required string FullName { get; set; }
    public required string Title { get; set; }
    public List<FamilyTreeNode>? Children { get; set; }
    public FamilyTreeNode? Spouse { get; set; }

    [System.Text.Json.Serialization.JsonIgnore]
    public FamilyTreeNode? Parent { get; set; }

    public enum RelationshipType
    {
        Child,
        Sibling,
        Spouse
    }
}