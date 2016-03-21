using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IssueBook f = new IssueBook();
            f.Visible = true;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Visible = true;
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Visible = true;
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBorrower f = new AddBorrower();
            f.Visible = true;
            
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBorrower f = new UpdateBorrower();
            f.Visible = true;
         
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBorrower f = new DeleteBorrower();
            f.Visible = true;
           
        }

        private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBorrower f = new ViewBorrower();
            f.Visible = true;
            
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBook f = new IssueBook();
            f.Visible = true;
           
        }

        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook f = new AddBook();
            f.Visible = true;
        }

        private void updateBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBook f = new UpdateBook();
            f.Visible = true;
        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBook f = new DeleteBook();
            f.Visible = true;
        }

        private void viewBookDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBookDetails f = new ViewBookDetails();
            f.Visible = true;
        }

        private void viewIssuedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewIssued f = new ViewIssued();
            f.Visible = true;
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return f = new Return();
            f.Visible = true;
        }

        private void bookReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return f = new Return();
            f.Visible = true;
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBook f = new IssueBook();
            f.Visible = true;

        }

        private void addUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddBorrower f = new AddBorrower();
            f.Visible = true;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Visible = true;
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 f = new AboutBox1();
            f.Visible = true;
        }
    }
}
