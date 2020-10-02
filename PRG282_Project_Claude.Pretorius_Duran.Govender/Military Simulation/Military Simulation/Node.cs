using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Military_Simulation
{
        public class Node : Panel, IComparable<Node>
        {

        public int id;
        public int f;
        public int g;
        public int h;
        public int last;
        public int row;
        public int col;

        public int x;
        public int y;
        public Point coords;
        public List<Node> neighbors;
        public int total_rows;
        public int type;
        public int priority;
        public Node(int id, int f, int g, int h, int last, int type, int row, int col, int width, int total_rows)
        {
            this.row = row;
            this.col = col;
            this.id = id;
            this.last = last;
            this.x = row * width;
            this.y = col * width;
            this.coords = new Point(x, y);
            this.neighbors = new List<Node>();
            this.BackColor = Color.White;
            this.total_rows = total_rows;
            this.type = type;
            this.Height = width;
            this.Width = width;
            this.f = f;
            this.g = g;
            this.h = h;
            this.priority = f;

        }
        public int CompareTo(Node other)
        {
            this.priority = f;
            if (this.priority < other.priority) return -1;
            else if (this.priority > other.priority) return 1;
            else return 0;
        }
        public Point get_pos_grid()
        {
            return new Point(this.row, this.col);
        }
        public Point get_pos_pixel()
        {
            return new Point(this.x, this.y);
        }
        public bool is_closed()
        {
            return this.type == 4;
        }
        public bool is_open()
        {
            return this.type == 5;
        }
        public bool is_obstacle()
        {
            return this.type == 3;
        }
        public bool is_start()
        {
            return this.type == 1;
        }
        public bool is_end()
        {
            return this.type == 2;
        }
        public void reset()
        {
            this.type = 0;
            this.BackColor = Color.White;
        }
        public void make_closed()
        {
            this.type = 4;
            this.BackColor = Color.Red;
        }
        public void make_open()
        {
            this.type = 5;
            this.BackColor = Color.Green;
        }
        public void make_obstacle()
        {
            this.type = 3;
            this.BackColor = Color.Black;
        }
        public void make_end()
        {
            this.type = 2;
            this.BackColor = Color.Turquoise;
        }
        public void make_path()
        {
            this.BackColor = Color.Purple;
        }
        public void make_start()
        {
            this.type = 1;
            this.BackColor = Color.Orange;
        }
        public void make_default()
        {
            this.type = 0;
            this.BackColor = Color.White;
        }
    }
}
