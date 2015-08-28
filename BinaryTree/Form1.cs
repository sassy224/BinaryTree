using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BinaryTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Variable to represent the binary tree
        /// </summary>
        private BinaryTree _tree;

        /// <summary>
        /// The base value of X
        /// </summary>
        private int _baseX = 2;

        /// <summary>
        /// The base value of Y
        /// </summary>
        private int _baseY = 1;

        /// <summary>
        /// The base value of the tree's level
        /// </summary>
        private int _maxDeepLevel = 7;

        /// <summary>
        /// A random generator
        /// </summary>
        private Random _rnd = new Random();

        /// <summary>
        /// The dictionary to store all the node value and their corresponding nodes
        /// </summary>
        private Dictionary<int, List<Node>> _nodeDictionary = new Dictionary<int, List<Node>>();

        /// <summary>
        /// The array of Brush color for marking the duplicated nodes
        /// </summary>
        Brush[] BrushColors = new Brush[] {
          Brushes.Aqua,
          Brushes.Blue,
          Brushes.Red,
          Brushes.Yellow,
          Brushes.Green,
          Brushes.Orange,
          Brushes.Navy,
          Brushes.Brown,
          Brushes.Chocolate,
          Brushes.Coral,
          Brushes.Crimson,
          Brushes.Cyan,
          Brushes.DarkKhaki,
          Brushes.Firebrick,
          Brushes.ForestGreen
        };

        /// <summary>
        /// Paint the tree and show it inside the PictureBox
        /// </summary>
        private void PaintTree()
        {
            if (_tree == null) return;
            pictureBox1.Image = _tree.Draw();
        }

        /// <summary>
        /// Create a random binary tree with selected settings
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">EventArgs</param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateTree();
        }

        /// <summary>
        /// Actions when form is loaded
        /// </summary>
        /// <param name="sender">Form</param>
        /// <param name="e">EventArgs</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Default settings
            txtBaseX.Text = _baseX.ToString();
            txtBaseY.Text = _baseY.ToString();
            txtTreeLevel.Text = _maxDeepLevel.ToString();

            //Create a random binary tree
            CreateTree();
        }

        /// <summary>
        /// Populate the left child node and randomly populate the right child node of a node and
        /// their children nodes
        /// </summary>
        /// <param name="node">The node to be populate</param>
        /// <param name="level">The level of the tree</param>
        /// <returns>The node that was passed to, now with children</returns>
        private Node PopulateLeftRightNode(Node node, int level)
        {
            if (level < _maxDeepLevel)
            {
                level += 1;

                node.Left = PopulateLeftRightNode(new Node(node.Value + _baseX), level);

                //Randomly create the right child node
                if (_rnd.Next(1, 999) % 2 > 0)
                {
                    node.Right = PopulateLeftRightNode(new Node(node.Value + _baseY), level);
                }
            }

            return node;
        }

        /// <summary>
        /// Create a binary tree
        /// </summary>
        private void CreateTree()
        {
            //Init the tree
            _tree = new BinaryTree();
            lblMsg.Text = @"Random binary tree created";

            //Add a new node, to the right side of the root node
            Node currentNode = new Node(0);
            _tree.Add(currentNode, false);

            //Populate its children nodes
            PopulateLeftRightNode(currentNode, 0);

            //Draw the tree
            PaintTree();

            //Update label
            lblCount.Text = _tree.Count.ToString();
        }

        /// <summary>
        /// Traverse a binary tree in InOrder order using Morris' algorithm
        /// http://www.geeksforgeeks.org/inorder-tree-traversal-without-recursion-and-without-stack/ 
        /// http://geeksquiz.com/threaded-binary-tree/
        /// </summary>
        /// <param name="root">The root node of a binary tree</param>
        private void TraveseInOrderUsingMorris(Node root)
        {
            Node current = root;
            Node predecessor = null;

            //Reset the dict
            _nodeDictionary = new Dictionary<int, List<Node>>();

            while (current != null)
            {
                if (current.Left == null) //The leftmost node of current branch
                {
                    //Process the node
                    ProcessNode(current);
                    current = current.Right;
                }
                else
                {
                    //Find the inorder predecessor of current
                    predecessor = current.Left;

                    while (predecessor.Right != null && predecessor.Right != current)
                    {
                        predecessor = predecessor.Right; //The rightmost node of current branch
                    }

                    //Make current as right child of its inorder predecessor
                    if (predecessor.Right == null)
                    {
                        predecessor.Right = current; //Make a thread link to current
                        current = current.Left;
                    }
                    else
                    {
                        //Revert the changes made to restore the original tree
                        //i.e., remove the thread link to current (the right child of predecssor)
                        predecessor.Right = null;

                        //Process the node
                        ProcessNode(current);
                        current = current.Right;
                    }
                }
            }
        }

        /// <summary>
        /// Process the node, insert it to the correct position in the dictionary
        /// </summary>
        /// <param name="node">The node to be processed</param>
        private void ProcessNode(Node node)
        {
            if (_nodeDictionary.ContainsKey(node.Value))
            {
                //Node already exists.
                //Add it to the list of node with the same value
                _nodeDictionary[node.Value].Add(node);
            }
            else
            {
                //New node
                //Create a list to store its value
                _nodeDictionary[node.Value] = new List<Node>();

                //Store the list as value of the key (node's value)
                _nodeDictionary[node.Value].Add(node);
            }
        }

        /// <summary>
        /// Check the current binary tree for duplicated nodes
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">EventArgs</param>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            StringBuilder sbDupGroupsMsg = new StringBuilder("Duplicated notes: ");
            StringBuilder sbElapTime = new StringBuilder();
            int colorIdx = 0;

            //For timing
            double totalElapsed = 0;
            double elapsedMs;

            var executionTime = Stopwatch.StartNew();

            //Traverse tree using Morris algorithm
            TraveseInOrderUsingMorris(_tree.RootNode);

            executionTime.Stop();
            elapsedMs = executionTime.Elapsed.Milliseconds;
            totalElapsed += elapsedMs;

            sbElapTime.AppendFormat("Traverse's time: {0}ms, ", elapsedMs);

            executionTime = Stopwatch.StartNew();

            //Go through all the keys (node's value) in the dictionary
            foreach (List<Node> group in _nodeDictionary.Values)
            {
                if (group.Count > 1) //This list contains duplicated nodes
                {
                    sbDupGroupsMsg.AppendFormat("{0} ({1} times), ", group[0].Value, group.Count());

                    //Update color for these nodes to make them more visible
                    Brush color = BrushColors[colorIdx];
                    foreach (Node node in group)
                    {
                        node.BrushColor = color;
                    }
                    colorIdx += 1;

                    //Reset color index if colors are all used up
                    colorIdx = colorIdx < BrushColors.Length ? colorIdx : 0;
                }
            }
            executionTime.Stop();
            elapsedMs = executionTime.Elapsed.Milliseconds;
            totalElapsed += elapsedMs;

            sbElapTime.AppendFormat("Count groups' time: {0}ms, ", elapsedMs);

            executionTime = Stopwatch.StartNew();

            //Draw the tree
            PaintTree();
            executionTime.Stop();
            elapsedMs = executionTime.Elapsed.Milliseconds;
            totalElapsed += elapsedMs;
            sbElapTime.AppendFormat("Paint tree's time: {0}ms, ", elapsedMs);
            sbElapTime.AppendFormat("Total elapsed time: {0}ms, ", totalElapsed);

            //Update text
            lblMsg.Text = sbDupGroupsMsg.ToString();
            lblTime.Text = sbElapTime.ToString();
        }

        private void txtBaseX_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (Int32.TryParse(txtBaseX.Text, out temp))
            {
                _baseX = Int32.Parse(txtBaseX.Text);
            }
        }

        private void txtBaseY_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (Int32.TryParse(txtBaseY.Text, out temp))
            {
                _baseY = Int32.Parse(txtBaseY.Text);
            }
        }

        private void txtTreeLevel_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (Int32.TryParse(txtTreeLevel.Text, out temp))
            {
                _maxDeepLevel = Int32.Parse(txtTreeLevel.Text);

                //Only allow max level 10, more make it difficult to see the tree
                if (_maxDeepLevel > 10) _maxDeepLevel = 10;
            }
        }
    }
}