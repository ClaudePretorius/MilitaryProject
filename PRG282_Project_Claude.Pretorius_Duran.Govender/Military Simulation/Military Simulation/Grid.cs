using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Military_Simulation
{
    public class Grid
    {
        public int height;
        public int width;
        public int numOfRows;
        public int numOfCols;
        Dictionary<Node, Node> came_from = new Dictionary<Node, Node>();
        public Node[,] grid { get; set; }
        public int startCount = 0;
        public int endCount = 0;

        public Grid(int height, int width, int numOfRows, int numOfCols)
        {
            this.height = height;
            this.width = width;
            this.numOfRows = numOfRows;
            this.numOfCols = numOfCols;
            this.grid = new Node[numOfRows, numOfCols];

        }

        Node addNode(string name, int xpos, int ypos, int x, int y, double width, int id, int numOfRows)
        {

            Node l = new Node(id, 0, 0, 0, 0, 0, x, y, Convert.ToInt32(width), numOfRows);
            l.Name = name;
            l.Location = new System.Drawing.Point(xpos, ypos);
            l.BorderStyle = BorderStyle.FixedSingle;
            return l;
        }



        public bool astar()
        {
            int count = 0;
            Node startNode = new Node(0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            Node endNode = new Node(0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            HashSet<Node> open_set_hash = new HashSet<Node>();
            PriorityQueue<Node> open_set = new PriorityQueue<Node>();

            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfCols; j++)
                {
                    grid[i, j].f = 2147483647;
                    grid[i, j].g = 2147483647;

                    if (grid[i, j].is_start())
                    {
                        startNode = grid[i, j];
                    }
                    if (grid[i, j].is_end())
                    {
                        endNode = grid[i, j];
                    }
                }
            }

            startNode.g = 0;
            startNode.f = h(startNode.get_pos_grid(), endNode.get_pos_grid());
            open_set.Add(startNode);

            open_set_hash.Add(startNode);
            bool running = true;

            while (running)
            {
                if (open_set.Count() == 0)
                {
                    running = false;
                }
                Node current = open_set.Dequeue();
                open_set_hash.Remove(current);

                if (current == endNode)
                {
                    print_path(current);
                    current.make_end();
                    return true;
                }
                foreach (Node neighbor in current.neighbors)
                {
                    int temp_g_score = current.g + 1;
                    if (temp_g_score < neighbor.g)
                    {
                        came_from[neighbor] = current;

                        neighbor.g = temp_g_score;
                        neighbor.f = temp_g_score + h(neighbor.get_pos_grid(), endNode.get_pos_grid());
                        if (!open_set_hash.Contains(neighbor))
                        {
                            count += 1;
                            open_set.Add(neighbor);
                            open_set_hash.Add(neighbor);
                            neighbor.make_open();
                        }

                    }
                }
                if (current != startNode)
                {
                    current.make_closed();
                }

            }
            return false;

        }
        public void print_path(Node current)
        {
            while (came_from.ContainsKey(current))
            {
                current = came_from[current];
                current.make_path();
            }
        }
        public int h(Point p1, Point p2)
        {
            double x = Math.Pow(p1.X - p2.X, 2.0);
            double y = Math.Pow(p1.Y - p2.Y, 2.0);
            return (int)(x + y);
        }
        public void mouseEnter(object sender, MouseEventArgs e)
        {

            if (e.Button != MouseButtons.None)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Control control = (Control)sender;
                    Node currentNode = (Node)sender;
                    currentNode.make_obstacle();
                    if (control.Capture)
                    {
                        control.Capture = false;
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    Control control = (Control)sender;
                    Node currentNode = (Node)sender;
                    currentNode.make_default();
                    if (control.Capture)
                    {
                        control.Capture = false;
                    }
                }
            }


        }
        public void mouseClick(object sender, MouseEventArgs e)
        {
            Node currentNode = (Node)sender;
            switch (e.Button)
            {
                case MouseButtons.Left:

                    if (!State.startNodeState)
                    {
                        State.startNodeState = !State.startNodeState;
                        currentNode.make_start();
                    }
                    else if (State.startNodeState)
                    {
                        if (currentNode.is_start())
                        {
                            currentNode.make_default();
                            State.startNodeState = !State.startNodeState;
                        }
                    }
                    break;

                case MouseButtons.Right:
                    if (!State.endNodeState)
                    {
                        State.endNodeState = !State.endNodeState;
                        currentNode.make_end();
                    }
                    else if (State.endNodeState)
                    {
                        if (currentNode.is_end())
                        {
                            currentNode.make_default();
                            State.endNodeState = !State.endNodeState;
                        }
                    }
                    break;

            }
        }
        public void update_neighbors()
        {
            Node startingNode = new Node(0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            Node endingNode = new Node(0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfCols; j++)
                {
                    if (i < this.numOfRows - 1 && !grid[i + 1, j].is_obstacle())// DOWN
                    {
                        Node temp = grid[i + 1, j];
                        grid[i, j].neighbors.Add(temp);
                    }

                    if (i > 0 && !grid[i - 1, j].is_obstacle())// UP
                    {
                        Node temp = grid[i - 1, j];
                        grid[i, j].neighbors.Add(temp);
                    }

                    if (j < this.numOfRows - 1 && !grid[i, j + 1].is_obstacle())// RIGHT
                    {
                        Node temp = grid[i, j + 1];
                        grid[i, j].neighbors.Add(temp);
                    }

                    if (j > 0 && !grid[i, j - 1].is_obstacle())// LEFT
                    {
                        Node temp = grid[i, j - 1];
                        grid[i, j].neighbors.Add(temp);
                    }
                }
            }
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfCols; j++)
                {
                    if (grid[i, j].is_start())
                    {
                        startingNode = grid[i, j];
                    }
                    if (grid[i, j].is_end())
                    {
                        endingNode = grid[i, j];
                    }
                }
            }
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfCols; j++)
                {
                    grid[i, j].g = h(grid[i, j].get_pos_grid(), startingNode.get_pos_grid());
                    grid[i, j].h = h(endingNode.get_pos_grid(), grid[i, j].get_pos_grid());
                    grid[i, j].f = grid[i, j].g + grid[i, j].h;
                }
            }
            MessageBox.Show("Neighbors updated.");
        }
        public void make_grid()
        {
            int id = 0;
            int node_width = (int)(this.width / this.numOfCols);
            int node_height = (int)(this.height  / this.numOfRows);
            for (int j = 0; j < this.numOfRows; j++)
            {
                for (int i = 0; i < this.numOfCols; i++)
                {
                    string pnlName = j.ToString() + "," + i.ToString();
                    int xpos = Convert.ToInt32(i * node_width);
                    int ypos = Convert.ToInt32(j * node_height);
                    Node node = addNode(pnlName, xpos, ypos, j, i, node_width, id, numOfRows);
                    id++;
                    grid[j, i] = node;
                    node.MouseClick += mouseClick;
                    node.MouseMove += mouseEnter;
                }
            }
        }
    }
}
