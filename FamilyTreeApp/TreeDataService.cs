public class TreeDataService
{
    public string UploadedJson { get; set; } = string.Empty;
    public FamilyTreeNode? RootNode { get; set; }

    public event Action? OnChange;
    
    public void SetRootNode(FamilyTreeNode node)
    {
        RootNode = node;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();

}