using app;
namespace app;
public class TreeNode
{
    private Token left;
    private Token mark;
    private Token right;
    private TreeNode rightNode;
    private TreeNode parent;

    public bool IsLeaf()
    {
        return rightNode == null;
    }

    public bool IsRoot()
    {
        return parent == null;
    }


}