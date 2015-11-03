using System.Windows;

namespace GameProgrammingPatterns
{
    class Tree
    {
        public TreeModel model;

        double height { get; set; }
        double width { get; set; }
        int xPos { get; set; }
        int yPos { get; set; }

        public Tree()
        {
            model = TreeModel.Instance;
        }
    }
}
