using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingPatterns
{
    public sealed class TreeModel
    {
        private static TreeModel _instance = new TreeModel();

        private Texture treeTexture;
        private Mesh treeMesh;

        public static TreeModel Instance
        {
            get { return _instance; }
        }

        private TreeModel()
        {
            treeTexture = new Texture();
            treeMesh = new Mesh();
        }
    }

    class Texture
    {
        private string textureColour;

        public Texture()
        {
            textureColour = "green";
        }
    }

    class Mesh
    {
        private string meshColour;

        public Mesh()
        {
            meshColour = "blue";
        }
    }

}
