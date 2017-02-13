using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometryCalculator
{
    public partial class frmGeoCalc : Form
    {
        public frmGeoCalc()
        {
            InitializeComponent();
        }

        int ShapeSelected = 1;
        int OutPutSelected = 1;

        string[] strMeasurements = new string[10] { "", "0", "", "0", "", "0", "", "0", "", "0"};
        decimal[] sortedInputs = new decimal[10];
        bool[] validInputs = new bool[5] { true, true, true, true, true };

        private void radShape_Click(object sender, EventArgs e)
        {
            RadioButton cb = (RadioButton)sender;
            switch (cb.Text)
            {
                case "Rectangle":
                    ShapeSelected = 1;
                    pictureBox1.Image = GeometryCalculator.Properties.Resources.rectangleClear;
                    resetForm();
                    setFormula(ShapeSelected, OutPutSelected);
                    break;
                case "Square":
                    ShapeSelected = 2;
                    pictureBox1.Image = GeometryCalculator.Properties.Resources.squareClear;
                    resetForm();
                    setFormula(ShapeSelected, OutPutSelected);
                    break;
                case "Parallelogram":
                    ShapeSelected = 3;
                    pictureBox1.Image = GeometryCalculator.Properties.Resources.parallelogramClear;
                    resetForm();
                    setFormula(ShapeSelected, OutPutSelected);
                    break;
                case "Rhombus":
                    ShapeSelected = 4;
                    pictureBox1.Image = GeometryCalculator.Properties.Resources.rhombusClear;
                    lblMeasurement1.Visible = false;
                    resetForm();
                    setFormula(ShapeSelected, OutPutSelected);
                    break;
                case "Triangle":
                    ShapeSelected = 5;
                    pictureBox1.Image = GeometryCalculator.Properties.Resources.triangleClear;
                    resetForm();
                    setFormula(ShapeSelected, OutPutSelected);
                    break;
                case "Trapezoid":
                    ShapeSelected = 6;
                    pictureBox1.Image = GeometryCalculator.Properties.Resources.trapezoidClear;
                    resetForm();
                    setFormula(ShapeSelected, OutPutSelected);
                    break;
                case "Circle":
                    ShapeSelected = 7;
                    pictureBox1.Image = GeometryCalculator.Properties.Resources.circleClear;
                    resetForm();
                    setFormula(ShapeSelected, OutPutSelected);
                    break;
                default:
                    break;
            }
        }

        private void setFormula(int shape, int output)
        {
            switch (shape) // changes shape for formula displayed
            {
                case 1: // Rectangle
                    switch (output) // Changes Displayed formula for output selection
                    {
                        case 1:
                            lblFormulaOneName.Text = "Area: ";
                            lblFormulaTwoName.Visible = false;
                            lblFormulaOne.Text = "l × w";
                            lblFormulaTwo.Visible = false;
                            break;
                        case 2:
                            lblFormulaOneName.Text = "Perimeter: ";
                            lblFormulaTwoName.Visible = false;
                            lblFormulaOne.Text = " l + l + w + w";
                            lblFormulaTwo.Visible = false;
                            break;
                        default:
                            lblFormulaOneName.Text = "Area: ";
                            lblFormulaOne.Text = "l × w";
                            lblFormulaTwoName.Visible = true;
                            lblFormulaTwoName.Text = "Perimeter: ";
                            lblFormulaTwo.Visible = true;
                            lblFormulaTwo.Text = " l + l + w + w";
                            break;
                    }
                    break;
                case 2: // Square
                    switch (output)
                    {
                        case 1: // Area
                            lblFormulaOneName.Text = "Area: ";
                            lblFormulaTwoName.Visible = false;
                            lblFormulaOne.Text = " s\xB2";
                            lblFormulaTwo.Visible = false;
                            break;
                        case 2: // Perimeter
                            lblFormulaOneName.Text = "Perimeter: ";
                            lblFormulaTwoName.Visible = false;
                            lblFormulaOne.Text = "s + s + s + s";
                            lblFormulaTwo.Visible = false;
                            break;
                        default:
                            lblFormulaOneName.Text = "Area: ";
                            lblFormulaOne.Text = " s\xB2";
                            lblFormulaTwoName.Visible = true;
                            lblFormulaTwoName.Text = "Perimeter: ";
                            lblFormulaTwo.Visible = true;
                            lblFormulaTwo.Text = "s + s + s + s";
                            break;
                    }
                    break;
                case 3: // Parallelogram
                    switch (output)
                    {
                        case 1:
                            lblFormulaOneName.Text = "Area: ";
                            lblFormulaTwoName.Visible = false;
                            lblFormulaOne.Text = "b × h";
                            lblFormulaTwo.Visible = false;
                            break;
                        case 2:
                            lblFormulaOneName.Text = "Perimeter: ";
                            lblFormulaTwoName.Visible = false;
                            lblFormulaOne.Text = "a + a + b + b";
                            lblFormulaTwo.Visible = false;
                            break;
                        default:
                            lblFormulaOneName.Text = "Area: ";
                            lblFormulaOne.Text = "b × h";
                            lblFormulaTwoName.Visible = true;
                            lblFormulaTwoName.Text = "Perimeter: ";
                            lblFormulaTwo.Visible = true;
                            lblFormulaTwo.Text = "a + a + b + b";
                            break;
                    }
                    break;
                case 4: // Rhombus
                    switch (output)
                    {
                        case 1:
                            lblFormulaOneName.Text = "Area: ";
                            lblFormulaTwoName.Visible = false;
                            lblFormulaOne.Text = "b × h";
                            lblFormulaTwo.Visible = false;
                            break;
                        case 2:
                            lblFormulaOneName.Text = "Perimeter: ";
                            lblFormulaTwoName.Visible = false;
                            lblFormulaOne.Text = " b + b + b + b";
                            lblFormulaTwo.Visible = false;
                            break;
                        default:
                            lblFormulaOneName.Text = "Area: ";
                            lblFormulaOne.Text = "b × h";
                            lblFormulaTwoName.Visible = true;
                            lblFormulaTwoName.Text = "Perimeter: ";
                            lblFormulaTwo.Visible = true;
                            lblFormulaTwo.Text = " b + b + b + b";
                            break;
                    }
                    break;
                case 5: // Triangle
                    switch (output)
                    {
                        case 1:
                            lblFormulaOneName.Text = "Area: ";
                            lblFormulaTwoName.Visible = false;
                            lblFormulaOne.Text = "(b × h)/2";
                            lblFormulaTwo.Visible = false;
                            break;
                        case 2:
                            lblFormulaOneName.Text = "Perimeter: ";
                            lblFormulaTwoName.Visible = false;
                            lblFormulaOne.Text = "a + b + c";
                            lblFormulaTwo.Visible = false;
                            break;
                        default:
                            lblFormulaOneName.Text = "Area: ";
                            lblFormulaOne.Text = "(b × h)/2";
                            lblFormulaTwoName.Visible = true;
                            lblFormulaTwoName.Text = "Perimeter: ";
                            lblFormulaTwo.Visible = true;
                            lblFormulaTwo.Text = "a + b + c";
                            break;
                    }
                    break;
                case 6: // Trapezoid
                    switch (output)
                    {
                        case 1:
                            lblFormulaOneName.Text = "Area: ";
                            lblFormulaTwoName.Visible = false;
                            lblFormulaOne.Text = "( ( a + b ) / 2 ) x h";
                            lblFormulaTwo.Visible = false;
                            break;
                        case 2:
                            lblFormulaOneName.Text = "Perimeter: ";
                            lblFormulaTwoName.Visible = false;
                            lblFormulaOne.Text = "a + b + c + d";
                            lblFormulaTwo.Visible = false;
                            break;
                        default:
                            lblFormulaOneName.Text = "Area: ";
                            lblFormulaOne.Text = "( ( a + b ) / 2 ) x h";
                            lblFormulaTwoName.Visible = true;
                            lblFormulaTwoName.Text = "Perimeter: ";
                            lblFormulaTwo.Visible = true;
                            lblFormulaTwo.Text = "a + b + c + d";
                            break;
                    }
                    break;
                default:
                    switch (output)
                    {
                        case 1:
                            lblFormulaOneName.Text = "Area: ";
                            lblFormulaTwoName.Visible = false;
                            lblFormulaOne.Text = "\u03C0 × r\xB2";
                            lblFormulaTwo.Visible = false;
                            break;
                        case 2:
                            lblFormulaOneName.Text = "Perimeter: ";
                            lblFormulaTwoName.Visible = false;
                            lblFormulaOne.Text = "2\u03C0 × r";
                            lblFormulaTwo.Visible = false;
                            break;
                        default:
                            lblFormulaOneName.Text = "Area: ";
                            lblFormulaOne.Text = "\u03C0 × r\xB2";
                            lblFormulaTwoName.Visible = true;
                            lblFormulaTwoName.Text = "Perimeter: ";
                            lblFormulaTwo.Visible = true;
                            lblFormulaTwo.Text = "2\u03C0 × r";
                            break;
                    }
                    break;
            }
        }

        private void radArea_Click(object sender, EventArgs e)
        {
            RadioButton cb2 = (RadioButton)sender;
            switch (cb2.Text)
            {
                case "Area":
                    OutPutSelected = 1;
                    resetForm();
                    setFormula(ShapeSelected, OutPutSelected);
                    break;
                case "Perimeter":
                    OutPutSelected = 2;
                    resetForm();
                    setFormula(ShapeSelected, OutPutSelected);
                    break;
                default:
                    OutPutSelected = 3;
                    resetForm();
                    setFormula(ShapeSelected, OutPutSelected);
                    break;
            }

        }

        private void resetForm()
        {
            // Resets Inputs of form
            lblMeasurement1.Visible = false;
            lblMeasurement2.Visible = false;
            lblMeasurement3.Visible = false;
            lblMeasurement4.Visible = false;
            lblMeasurement5.Visible = false;

            lblMeasurement1.Tag = "";
            lblMeasurement2.Tag = "";
            lblMeasurement3.Tag = "";
            lblMeasurement4.Tag = "";
            lblMeasurement5.Tag = "";

            txtMeasurement1.Visible = false;
            txtMeasurement2.Visible = false;
            txtMeasurement3.Visible = false;
            txtMeasurement4.Visible = false;
            txtMeasurement5.Visible = false;

            txtMeasurement1.Text = "";
            txtMeasurement2.Text = "";
            txtMeasurement3.Text = "";
            txtMeasurement4.Text = "";
            txtMeasurement5.Text = "";

            btnCalculate.Text = "Calculate";

            // Resets Outputs of Form
            lblAnswerOne.Visible = false;
            txtAnswerOne.Visible = false;
            txtAnswerOne.Text = "";
            lblAnswerTwo.Visible = false;
            txtAnswerTwo.Visible = false;
            txtAnswerTwo.Text = "";

            resetSortedInputs();

        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "Calculate")
            {
                setInputForm(ShapeSelected, OutPutSelected);

                //switch (ShapeSelected)
                //{
                //    case 1: // Rectangle
                //        label1.Text = "l:";
                //        label1.Visible = true;
                //        txtLength.Visible = true;
                //        label2.Text = "w:";
                //        label2.Visible = true;
                //        txtWidth.Visible = true;
                //        btnCalculate.Text = "Answer";
                //        break;
                //    case 2: // Square
                //        label1.Text = "s:";
                //        label1.Visible = true;
                //        txtLength.Visible = true;
                //        btnCalculate.Text = "Answer";
                //        break;
                //    case 3: // Parallelogram
                //        if (OutPutSelected == 1)
                //        {
                //            label1.Text = "a:";
                //            label1.Visible = true;
                //            txtLength.Visible = true;
                //            label2.Text = "b:";
                //            label2.Visible = true;
                //            txtWidth.Visible = true;
                //        }
                //        else if (OutPutSelected == 2)
                //        {
                //            label1.Text = "a:";
                //            label1.Visible = true;
                //            txtLength.Visible = true;
                //            label2.Text = "h:";
                //            label2.Visible = true;
                //            txtWidth.Visible = true;
                //        }
                //        else
                //        {
                //            label1.Text = "a:";
                //            label1.Visible = true;
                //            txtLength.Visible = true;
                //            label2.Text = "b:";
                //            label2.Visible = true;
                //            txtWidth.Visible = true;
                //            label3.Text = "h:";
                //            label3.Visible = true;
                //            txtHeight.Visible = true;
                //        }
                //        btnCalculate.Text = "Answer";
                //        break;
                //    case 4: // 
                //        if (OutPutSelected == 1)
                //        {
                //            label1.Text = "b:";
                //            label1.Visible = true;
                //            txtLength.Visible = true;
                //            label2.Text = "h:";
                //            label2.Visible = true;
                //            txtWidth.Visible = true;

                //        }
                //        else if (OutPutSelected == 2)
                //        {
                //            label1.Text = "b:";
                //            label1.Visible = true;
                //            txtLength.Visible = true;
                //            label2.Text = "h:";
                //            label2.Visible = true;
                //            txtWidth.Visible = true;

                //        }
                //        else
                //        {

                //            label1.Text = "b:";
                //            label1.Visible = true;
                //            txtLength.Visible = true;
                //            label2.Text = "h:";
                //            label2.Visible = true;
                //            txtWidth.Visible = true;
                //        }
                //        btnCalculate.Text = "Answer";
                //        break;
                //    case 5:
                //        if (OutPutSelected == 1)
                //        {
                //            label1.Text = "b:";
                //            label1.Visible = true;
                //            txtLength.Visible = true;
                //            label2.Text = "h:";
                //            label2.Visible = true;
                //            txtWidth.Visible = true;
                //        }
                //        else if (OutPutSelected == 2)
                //        {
                //            label1.Text = "a:";
                //            label1.Visible = true;
                //            txtLength.Visible = true;
                //            label2.Text = "b:";
                //            label2.Visible = true;
                //            txtWidth.Visible = true;
                //            label3.Text = "c:";
                //            label3.Visible = true;
                //            txtHeight.Visible = true;
                //        }
                //        else
                //        {
                //            label1.Text = "a:";
                //            label1.Visible = true;
                //            txtLength.Visible = true;
                //            label2.Text = "b:";
                //            label2.Visible = true;
                //            txtWidth.Visible = true;
                //            label3.Text = "c:";
                //            label3.Visible = true;
                //            txtHeight.Visible = true;
                //            label4.Text = "h:";
                //            label4.Visible = true;
                //            txtBoxFour.Visible = true;
                //        }
                //        btnCalculate.Text = "Answer";
                //        break;
                //    case 6:
                //        if (OutPutSelected == 1)
                //        {
                //            label1.Text = "a:";
                //            label1.Visible = true;
                //            txtLength.Visible = true;
                //            label2.Text = "b:";
                //            label2.Visible = true;
                //            txtWidth.Visible = true;
                //            label3.Text = "h:";
                //            label3.Visible = true;
                //            txtHeight.Visible = true;
                //        }
                //        else if (OutPutSelected == 2)
                //        {
                //            label1.Text = "a:";
                //            label1.Visible = true;
                //            txtLength.Visible = true;
                //            label2.Text = "b:";
                //            label2.Visible = true;
                //            txtWidth.Visible = true;
                //            label3.Text = "c:";
                //            label3.Visible = true;
                //            txtHeight.Visible = true;
                //            label4.Text = "d:";
                //            label4.Visible = true;
                //            txtBoxFour.Visible = true;
                //        }
                //        else
                //        {
                //            label1.Text = "a:";
                //            label1.Visible = true;
                //            txtLength.Visible = true;
                //            label2.Text = "b:";
                //            label2.Visible = true;
                //            txtWidth.Visible = true;
                //            label3.Text = "c:";
                //            label3.Visible = true;
                //            txtHeight.Visible = true;
                //            label4.Text = "d:";
                //            label4.Visible = true;
                //            txtBoxFour.Visible = true;
                //            label5.Text = "h:";
                //            label5.Visible = true;
                //            txtBoxFive.Visible = true;
                //        }
                //        btnCalculate.Text = "Answer";
                //        break;
                //    case 7:
                //        label1.Text = "r:";
                //        label1.Visible = true;
                //        txtLength.Visible = true;
                //        btnCalculate.Text = "Answer";
                //        break;
                //}
                txtMeasurement1.Focus();
            }
            else
            {
                //decimal decMeasurement1 = validateInput(strMeasurements[1], validInputs[0]);
                //decimal decMeasurement2 = validateInput(strMeasurements[3], validInputs[1]);
                //decimal decMeasurement3 = validateInput(strMeasurements[5], validInputs[2]);
                //decimal decMeasurement4 = validateInput(strMeasurements[7], validInputs[3]);
                //decimal decMeasurement5 = validateInput(strMeasurements[9], validInputs[4]);

                //string strName1 = strMeasurements[0];
                //string strName2 = strMeasurements[2];
                //string strName3 = strMeasurements[4];
                //string strName4 = strMeasurements[6];
                //string strName5 = strMeasurements[8];


                // private void calculateOutPut(length, width, side, bse, height, sideA, sideB, sideC, sideD, radius)

                MessageBox.Show("SortedInputs: \n" +
                "SortedInputs[0] - Length: " + sortedInputs[0] + "\n" +
                "SortedInputs[1] -  Width: " + sortedInputs[1] + "\n" +
                "SortedInputs[2] -   Side:" + sortedInputs[2] + "\n" +
                "SortedInputs[3] -    bse: " + sortedInputs[3] + "\n" +
                "SortedInputs[4] - height: " + sortedInputs[4] + "\n" +
                "SortedInputs[5] -  sideA: " + sortedInputs[5] + "\n" +
                "SortedInputs[6] -  sideB: " + sortedInputs[6] + "\n" +
                "SortedInputs[7] -  sideC: " + sortedInputs[7] + "\n" +
                "SortedInputs[8] -  sideD: " + sortedInputs[8] + "\n" +
                "SortedInputs[9] - radius: " + sortedInputs[9] + "\n");


                sortInputs();

                MessageBox.Show("SortedInputs: \n" +
                "SortedInputs[0] - Length: " + sortedInputs[0] + "\n" +
                "SortedInputs[1] -  Width: " + sortedInputs[1] + "\n" +
                "SortedInputs[2] -   Side:" + sortedInputs[2] + "\n" +
                "SortedInputs[3] -    bse: " + sortedInputs[3] + "\n" +
                "SortedInputs[4] - height: " + sortedInputs[4] + "\n" +
                "SortedInputs[5] -  sideA: " + sortedInputs[5] + "\n" +
                "SortedInputs[6] -  sideB: " + sortedInputs[6] + "\n" +
                "SortedInputs[7] -  sideC: " + sortedInputs[7] + "\n" +
                "SortedInputs[8] -  sideD: " + sortedInputs[8] + "\n" +
                "SortedInputs[9] - radius: " + sortedInputs[9] + "\n");

                setOutputForm(OutPutSelected);
                calculateOutPut(ShapeSelected, OutPutSelected, sortedInputs[0], sortedInputs[1], sortedInputs[2],
                    sortedInputs[3], sortedInputs[4], sortedInputs[5], sortedInputs[6], sortedInputs[7],
                    sortedInputs[8], sortedInputs[9]);
                txtMeasurement1.Focus();

                //switch (ShapeSelected)
                //{
                //    case 1:  // Rectangle
                //        if (OutPutSelected == 1) // area
                //        {
                //            decimal Area = squareArea(Convert.ToDecimal(txtLength.Text), Convert.ToDecimal(txtWidth.Text));
                //            // double Lenght = Convert.ToInt64((txtLength.Text));  
                //            // double Width = Convert.ToInt64((txtWidth.Text));
                //            // double Aera = Lenght * Width;
                //            label6.Visible = true;
                //            label6.Text = "Area:";
                //            txtAnswerOne.Visible = true;
                //            txtAnswerOne.Text = Convert.ToString(Area);
                //        }
                //        else if (OutPutSelected == 2) // peremiter
                //        {
                //            decimal Perim = squarePerimeter(Convert.ToDecimal(txtLength.Text), Convert.ToDecimal(txtWidth.Text));
                //            // double Lenght = Convert.ToInt64((txtLength.Text));
                //            // double Width = Convert.ToInt64((txtWidth.Text));
                //            // double Perim = Lenght + Lenght + Width + Width;
                //            label6.Visible = true;
                //            label6.Text = "Perimiter";
                //            txtAnswerOne.Visible = true;
                //            txtAnswerOne.Text = Convert.ToString(Perim);

                //        }
                //        else
                //        {
                //            double Lenght = Convert.ToInt64((txtLength.Text));
                //            double Width = Convert.ToInt64((txtWidth.Text));
                //            double Aera = Lenght * Width;
                //            double Perim = Lenght + Lenght + Width + Width;
                //            label6.Visible = true;
                //            label6.Text = "Area";
                //            txtAnswerOne.Visible = true;
                //            txtAnswerOne.Text = Convert.ToString(Aera);
                //            label7.Visible = true;
                //            label7.Text = "Perimiter";
                //            txtAnswerTwo.Visible = true;
                //            txtAnswerTwo.Text = Convert.ToString(Perim);
                //        }
                //        break;

                //}
            }
        }

        // private void calculateOutPut(length, width, side, bse, height, sideA, sideB, sideC, sideD, radius)

        private void sortInputs()
        {
            for (int i = 0; i < strMeasurements.Length; i += 2)
            {
//                MessageBox.Show(strMeasurements[i] + strMeasurements[i+1]);
                switch (strMeasurements[i])
                {
                    case "length":
                        sortedInputs[0] = validateInput(strMeasurements[i + 1], validInputs[0]);
//                        MessageBox.Show("test");
                        break;
                    case "width":
                        sortedInputs[1] = validateInput(strMeasurements[i + 1], validInputs[0]);
                        break;
                    case "side":
                        sortedInputs[2] = validateInput(strMeasurements[i + 1], validInputs[0]);
                        break;
                    case "bse":
                        sortedInputs[3] = validateInput(strMeasurements[i + 1], validInputs[0]);
                        break;
                    case "height":
                        sortedInputs[4] = validateInput(strMeasurements[i + 1], validInputs[0]);
                        break;
                    case "sideA":
                        sortedInputs[5] = validateInput(strMeasurements[i + 1], validInputs[0]);
                        break;
                    case "sideB":
                        sortedInputs[6] = validateInput(strMeasurements[i + 1], validInputs[0]);
                        break;
                    case "sideC":
                        sortedInputs[7] = validateInput(strMeasurements[i + 1], validInputs[0]);
                        break;
                    case "sideD":
                        sortedInputs[8] = validateInput(strMeasurements[i + 1], validInputs[0]);
                        break;
                    case "radius":
                        sortedInputs[9] = validateInput(strMeasurements[i + 1], validInputs[0]);
                        break;
                    default:
                        break;
                }
            }
        }

        private decimal validateInput(string v, bool valid)
        {
            decimal measurement;
            valid = decimal.TryParse(v, out measurement);
            return measurement;
        }

        private void setOutputForm(int outPutSelected)
        {
            switch (outPutSelected)
            { 
                case 1:  // Make Area Visiable
                    lblAnswerOne.Visible = true;
                    lblAnswerOne.Text = "Area:";
                    txtAnswerOne.Visible = true;
                    break;
                case 2: // Make Periemeter visiable
                    lblAnswerOne.Visible = true;
                    lblAnswerOne.Text = "Perimiter";
                    txtAnswerOne.Visible = true;
                    break;
                default: //
                    lblAnswerOne.Visible = true;
                    lblAnswerOne.Text = "Area";
                    txtAnswerOne.Visible = true;
                    lblAnswerTwo.Visible = true;
                    lblAnswerTwo.Text = "Perimiter";
                    txtAnswerTwo.Visible = true;
                break;
            }
        }

        private void setInputForm(int shape, int output)
        {
            switch (shape)
            {
                case 1: // Rectangle
                    lblMeasurement1.Text = "l:";
                    lblMeasurement1.Visible = true;
                    txtMeasurement1.Visible = true;
                    lblMeasurement1.Tag = "length";

                    lblMeasurement2.Text = "w:";
                    lblMeasurement2.Visible = true;
                    txtMeasurement2.Visible = true;
                    lblMeasurement2.Tag = "width";
                    btnCalculate.Text = "Answer";
                    break;
                case 2: // Square
                    lblMeasurement1.Text = "s:";
                    lblMeasurement1.Visible = true;
                    txtMeasurement1.Visible = true;
                    lblMeasurement1.Tag = "side";
                    btnCalculate.Text = "Answer";
                    break;
                case 3: // Parallelogram
                    if (output == 1) // Area
                    {
                        lblMeasurement1.Text = "a:";
                        lblMeasurement1.Visible = true;
                        txtMeasurement1.Visible = true;
                        lblMeasurement1.Tag = "sideA";

                        lblMeasurement2.Text = "b:";
                        lblMeasurement2.Visible = true;
                        txtMeasurement2.Visible = true;
                        lblMeasurement2.Tag = "bse";

                    }
                    else if (output == 2) // Perimeter
                    {
                        lblMeasurement1.Text = "a:";
                        lblMeasurement1.Visible = true;
                        txtMeasurement1.Visible = true;
                        lblMeasurement1.Tag = "sideA";

                        lblMeasurement2.Text = "b:";
                        lblMeasurement2.Visible = true;
                        txtMeasurement2.Visible = true;
                        lblMeasurement2.Tag = "bse";
                    }
                    else
                    {
                        lblMeasurement1.Text = "a:";
                        lblMeasurement1.Visible = true;
                        txtMeasurement1.Visible = true;
                        lblMeasurement1.Tag = "sideA";

                        lblMeasurement2.Text = "b:";
                        lblMeasurement2.Visible = true;
                        txtMeasurement2.Visible = true;
                        lblMeasurement2.Tag = "bse";

                        lblMeasurement3.Text = "h:";
                        lblMeasurement3.Visible = true;
                        txtMeasurement3.Visible = true;
                        lblMeasurement3.Tag = "height";
                    }
                    btnCalculate.Text = "Answer";
                    break;
                case 4: // Rhombus
                    if (output == 1)
                    {
                        lblMeasurement1.Text = "b:";
                        lblMeasurement1.Visible = true;
                        txtMeasurement1.Visible = true;
                        lblMeasurement1.Tag = "bse";

                        lblMeasurement2.Text = "h:";
                        lblMeasurement2.Visible = true;
                        txtMeasurement2.Visible = true;
                        lblMeasurement2.Tag = "height";
                    }
                    else if (output == 2)
                    {
                        lblMeasurement1.Text = "b:";
                        lblMeasurement1.Visible = true;
                        txtMeasurement1.Visible = true;
                        lblMeasurement1.Tag = "bse";

                        lblMeasurement2.Text = "h:";
                        lblMeasurement2.Visible = true;
                        txtMeasurement2.Visible = true;
                        lblMeasurement2.Tag = "height";
                    }
                    else
                    {

                        lblMeasurement1.Text = "b:";
                        lblMeasurement1.Visible = true;
                        txtMeasurement1.Visible = true;
                        lblMeasurement1.Tag = "bse";

                        lblMeasurement2.Text = "h:";
                        lblMeasurement2.Visible = true;
                        txtMeasurement2.Visible = true;
                        lblMeasurement2.Tag = "height";
                    }
                    btnCalculate.Text = "Answer";
                    break;
                case 5: // Triangle
                    if (output == 1)
                    {
                        lblMeasurement1.Text = "b:";
                        lblMeasurement1.Visible = true;
                        txtMeasurement1.Visible = true;
                        lblMeasurement1.Tag = "bse";

                        lblMeasurement2.Text = "h:";
                        lblMeasurement2.Visible = true;
                        txtMeasurement2.Visible = true;
                        lblMeasurement2.Tag = "height";
                    }
                    else if (output == 2)
                    {
                        lblMeasurement1.Text = "a:";
                        lblMeasurement1.Visible = true;
                        txtMeasurement1.Visible = true;
                        lblMeasurement1.Tag = "sideA";

                        lblMeasurement2.Text = "b:";
                        lblMeasurement2.Visible = true;
                        txtMeasurement2.Visible = true;
                        lblMeasurement2.Tag = "sideB";

                        lblMeasurement3.Text = "c:";
                        lblMeasurement3.Visible = true;
                        txtMeasurement3.Visible = true;
                        lblMeasurement3.Tag = "sideC";
                    }
                    else
                    {
                        lblMeasurement1.Text = "a:";
                        lblMeasurement1.Visible = true;
                        txtMeasurement1.Visible = true;
                        lblMeasurement1.Tag = "sideA";

                        lblMeasurement2.Text = "b:";
                        lblMeasurement2.Visible = true;
                        txtMeasurement2.Visible = true;
                        lblMeasurement2.Tag = "sideB";

                        lblMeasurement3.Text = "c:";
                        lblMeasurement3.Visible = true;
                        txtMeasurement3.Visible = true;
                        lblMeasurement3.Tag = "sideC";

                        lblMeasurement4.Text = "h:";
                        lblMeasurement4.Visible = true;
                        txtMeasurement4.Visible = true;
                        lblMeasurement4.Tag = "height";
                    }
                    btnCalculate.Text = "Answer";
                    break;
                case 6: // Trapezoid
                    if (output == 1)
                    {
                        lblMeasurement1.Text = "a:";
                        lblMeasurement1.Visible = true;
                        txtMeasurement1.Visible = true;
                        lblMeasurement1.Tag = "sideA";

                        lblMeasurement2.Text = "b:";
                        lblMeasurement2.Visible = true;
                        txtMeasurement2.Visible = true;
                        lblMeasurement2.Tag = "sideB";

                        lblMeasurement3.Text = "h:";
                        lblMeasurement3.Visible = true;
                        txtMeasurement3.Visible = true;
                        lblMeasurement3.Tag = "height";
                    }
                    else if (output == 2)
                    {
                        lblMeasurement1.Text = "a:";
                        lblMeasurement1.Visible = true;
                        txtMeasurement1.Visible = true;
                        lblMeasurement1.Tag = "sideA";

                        lblMeasurement2.Text = "b:";
                        lblMeasurement2.Visible = true;
                        txtMeasurement2.Visible = true;
                        lblMeasurement2.Tag = "sideB";

                        lblMeasurement3.Text = "c:";
                        lblMeasurement3.Visible = true;
                        txtMeasurement3.Visible = true;
                        lblMeasurement3.Tag = "sideC";

                        lblMeasurement4.Text = "d:";
                        lblMeasurement4.Visible = true;
                        txtMeasurement4.Visible = true;
                        lblMeasurement4.Tag = "sideD";
                    }
                    else
                    {
                        lblMeasurement1.Text = "a:";
                        lblMeasurement1.Visible = true;
                        txtMeasurement1.Visible = true;
                        lblMeasurement1.Tag = "sideA";

                        lblMeasurement2.Text = "b:";
                        lblMeasurement2.Visible = true;
                        txtMeasurement2.Visible = true;
                        lblMeasurement2.Tag = "sideB";

                        lblMeasurement3.Text = "c:";
                        lblMeasurement3.Visible = true;
                        txtMeasurement3.Visible = true;
                        lblMeasurement3.Tag = "sideC";

                        lblMeasurement4.Text = "d:";
                        lblMeasurement4.Visible = true;
                        txtMeasurement4.Visible = true;
                        lblMeasurement4.Tag = "sideD";

                        lblMeasurement5.Text = "h:";
                        lblMeasurement5.Visible = true;
                        txtMeasurement5.Visible = true;
                        lblMeasurement5.Tag = "height";
                    }
                    btnCalculate.Text = "Answer";
                    break;
                case 7: // Circle
                    lblMeasurement1.Text = "r:";
                    lblMeasurement1.Visible = true;
                    txtMeasurement1.Visible = true;
                    lblMeasurement1.Tag = "radius";
                    btnCalculate.Text = "Answer";
                    break;
                default:
                    break;
            }
        }

        private decimal squarePerimeter(decimal length, decimal width)
        {
            return (2 * length) + (2 * width);
        }

        private decimal squareArea(decimal length, decimal width)
        {
            return length * width;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetControlls();
            hideInputs();
            clearMeasurements();
            clearAnswers();
            resetSortedInputs();

            // pictureBox1.Image = GeometryCalculator.Properties.Resources.rectangleClear;
            // ShapeSelected = 1;
            // OutPutSelected = 1;
            // radRectangle.Checked = true;
            // radArea.Checked = true;
            // btnCalculate.Text = "Calculate";

            // label1.Visible = false;
            // label2.Visible = false;
            // label3.Visible = false;
            // label4.Visible = false;
            // label5.Visible = false;
            // txtLength.Visible = false;
            // txtWidth.Visible = false;
            // txtHeight.Visible = false;
            // txtBoxFour.Visible = false;
            // txtBoxFive.Visible = false;

            // txtLength.Text = "";
            // txtWidth.Text = "";
            // txtHeight.Text = "";
            // txtBoxFour.Text = "";
            // txtBoxFive.Text = "";

            // label6.Visible = false;
            // label7.Visible = false;
            // txtAnswerOne.Visible = false;
            // txtAnswerTwo.Visible = false;
        }

        private void resetSortedInputs()
        {
            for (int i = 0; i < sortedInputs.Length; i++)
            {
                sortedInputs[i] = 0;
            }
        }

        private void resetControlls()
        {
            pictureBox1.Image = GeometryCalculator.Properties.Resources.rectangleClear;
            ShapeSelected = 1;
            OutPutSelected = 1;
            radRectangle.Checked = true;
            radArea.Checked = true;
            btnCalculate.Text = "Calculate";
        }

        private void hideInputs()
        {
            lblMeasurement1.Visible = false;
            lblMeasurement2.Visible = false;
            lblMeasurement3.Visible = false;
            lblMeasurement4.Visible = false;
            lblMeasurement5.Visible = false;

            txtMeasurement1.Visible = false;
            txtMeasurement2.Visible = false;
            txtMeasurement3.Visible = false;
            txtMeasurement4.Visible = false;
            txtMeasurement5.Visible = false;
        }

        private void clearAnswers()
        {
            lblAnswerOne.Visible = false;
            lblAnswerTwo.Visible = false;
            txtAnswerOne.Visible = false;
            txtAnswerTwo.Visible = false;
        }

        private void clearMeasurements()
        {
            txtMeasurement1.Text = "";
            txtMeasurement2.Text = "";
            txtMeasurement3.Text = "";
            txtMeasurement4.Text = "";
            txtMeasurement5.Text = "";
        }





        // something ive been working on outside class


        private void calculateOutPut(int shape, int output, decimal length = 0, decimal width = 0, decimal side = 0,
             decimal bse = 0, decimal height = 0, decimal sideA = 0, decimal sideB = 0, decimal sideC = 0,
             decimal sideD = 0, decimal radius = 0)

        {
            decimal decArea;
            decimal decPerimeter;

            switch (output)
            {


//  private decimal calculateArea(int shape, decimal length = 0, decimal width = 0, decimal bse = 0, 
//      decimal side = 0, decimal height = 0, decimal sideA = 0, decimal sideB = 0, decimal radius = 0)

                case 1: // Area
                    lblAnswerOne.Text = "Area:";
                    decArea = calculateArea(shape, length, width, bse, side, height, sideA, sideB, radius);
                    txtAnswerOne.Text = Convert.ToString(decArea);
                    break;


//        private decimal calculatePerimeter(int shape, decimal length = 0, decimal width = 0, decimal bse = 0,
//            decimal side = 0, decimal height = 0, decimal sideA = 0, decimal sideB = 0, decimal sideC = 0,
//            decimal sideD = 0, decimal radius = 0)


                case 2: // Perimeter
                    lblAnswerTwo.Text = "Perimeter";
                    decPerimeter = calculatePerimeter(shape, length, width, bse, side, height, sideA, sideB, sideC, sideD, radius);
                    txtAnswerOne.Text = Convert.ToString(decPerimeter);
                    break;
                case 3: // Area & Perimeter
                    lblAnswerOne.Text = "Area:";
                    decArea = calculateArea(shape, length, width, bse, side, height, sideA, sideB, radius);
                    txtAnswerOne.Text = Convert.ToString(decArea);

                    lblAnswerTwo.Text = "Perimeter";
                    decPerimeter = calculatePerimeter(shape, length, width, side, bse, height, sideA, sideB, sideC, sideD, radius);
                    txtAnswerTwo.Text = Convert.ToString(decPerimeter);
                    break;
            }

        }

        private decimal calculatePerimeter(int shape, decimal length = 0, decimal width = 0, decimal bse = 0, 
            decimal side = 0, decimal height = 0, decimal sideA = 0, decimal sideB = 0, decimal sideC = 0,
            decimal sideD = 0, decimal radius = 0)
        {
            switch (shape)
            {
                case 1: // Rectangle
                    return rectanglePerimeter(length, width);
                case 2: // Square
                    return sqrPerimeter(side);
                case 3: // Parallelogram
                    return rectanglePerimeter(bse, height);
                case 4: // Rhombus
                    return sqrPerimeter(bse);
                case 5: // Triangle
                    return trianglePerimeter(sideA, sideB, sideC);
                case 6: // Trapezoid
                    return trapezoidPerimeter(sideA, sideB, sideC, sideD);
                default: // Circle
                    return circlePerimeter(radius);
            }
        }

        private decimal circlePerimeter(decimal radius)
        {
            return Convert.ToDecimal(Convert.ToSingle(2 * radius) * Math.PI);
        }

        private decimal trapezoidPerimeter(decimal sideA, decimal sideB, decimal sideC, decimal sideD)
        {
            return sideA + sideB + sideC + sideD;
        }

        private decimal trianglePerimeter(decimal sideA, decimal sideB, decimal sideC)
        {
            return sideA + sideB + sideC;
        }

        private decimal sqrPerimeter(decimal side)
        {
            return rectanglePerimeter(side, side);
        }

        private decimal rectanglePerimeter(decimal length, decimal width)
        {
            return (2 * length) + (2 * width);
        }

        private decimal calculateArea(int shape, decimal length = 0, decimal width = 0, decimal bse = 0, 
            decimal side = 0, decimal height = 0, decimal sideA = 0, decimal sideB = 0, decimal radius = 0)
        {
            switch (shape)
            {
                case 1: // Rectangle
                    return rectangleArea(length, width);            // ( length, width )
                case 2: // Square
                    return sqrArea(side);                           // ( side )
                case 3: // Parallelogram
                    return rectangleArea(bse, height);              // ( base, height )
                case 4: // Rhombus
                    return rectangleArea(bse, height);              // ( base, height )
                case 5: // Triangle
                    return triangleArea(bse, height);               // ( base, height )
                case 6: // Trapezoid
                    return trapezoidArea(sideA, sideB, height);     // ( side a, side b, height )
                default: // Circle
                    return circleArea(radius);                      // ( radius )
            }
        }

        private decimal circleArea(decimal radius)
        {
            return Convert.ToDecimal(Math.PI * Math.Pow(Convert.ToDouble(radius), 2));
        }

        private decimal trapezoidArea(decimal a, decimal b, decimal h)
        {
            return ((a + b) / 2) * h;
        }

        private decimal triangleArea(decimal bse, decimal height)
        {
            return (rectangleArea(bse, height)) / 2;
        }

        private decimal sqrArea(decimal side)
        {
            return rectangleArea(side, side);
        }

        private decimal rectangleArea(decimal length, decimal width)
        {
            return length * width;
        }

        private void txtMeasurements_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;

            strMeasurements[Convert.ToInt16(txtBox.Tag) - 1] = getLableTag(Convert.ToInt16(txtBox.Tag));
            strMeasurements[Convert.ToInt16(txtBox.Tag)] = txtBox.Text;

        }

        private string getLableTag(int txtBxTag)
        {
            switch (txtBxTag)
            {
                case 1:
                    return Convert.ToString(lblMeasurement1.Tag);
                case 3:
                    return Convert.ToString(lblMeasurement2.Tag);
                case 5:
                    return Convert.ToString(lblMeasurement3.Tag);
                case 7:
                    return Convert.ToString(lblMeasurement4.Tag);
                default:
                    return Convert.ToString(lblMeasurement5.Tag);
            }
        }

        private void txtBoxGetFocus_Enter(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            txtBox.SelectAll();
        }
    }
}
