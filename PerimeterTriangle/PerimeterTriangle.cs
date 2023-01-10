using System.Windows.Forms;

namespace PerimeterTriangle
{
    public partial class PerimeterTriangle : Form
    {
        public PerimeterTriangle()
        {
            InitializeComponent();
        }
        private void PerimeterTriangle_Load(object sender, EventArgs e)
        {
            txtA.PlaceholderText = "Enter a value";
            txtB.PlaceholderText = "Enter a value";
            txtC.PlaceholderText = "Enter a value";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double aSide = Double.Parse(txtA.Text);
                double bSide = Double.Parse(txtB.Text);
                double cSide = Double.Parse(txtC.Text);

                if (bSide+cSide <= aSide)
                {
                    MessageBox.Show("Invalid: Side A cannot be greater than Side B & C.", "Warning Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (aSide+bSide <= cSide)
                {
                    MessageBox.Show("Invalid: Side C cannot be greater than Side A & B.", "Warning Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (aSide+cSide <= bSide)
                {
                    MessageBox.Show("Invalid: Side B cannot be greater than Side A & C.", "Warning Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double TriangleResult = aSide + bSide + cSide;
                    lbResult.Items.Add("Perimeter of Triangle " + "a: " + aSide + ", b: " + bSide + ", c: " + cSide + " = " + TriangleResult);
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Invalid input: Please enter a valid number.","Warning Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            lbResult.Items.Clear();
        }

    }
}