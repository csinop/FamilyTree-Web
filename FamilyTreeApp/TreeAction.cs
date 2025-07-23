public class TreeAction
{
    public enum ActionType { Add, Remove }

    public ActionType Type { get; set; }
    public required FamilyTreeNode AffectedNode { get; set; }
    public required FamilyTreeNode ParentNode { get; set; }
    public int OriginalIndex { get; set; } // for Redo (preserve position)
}