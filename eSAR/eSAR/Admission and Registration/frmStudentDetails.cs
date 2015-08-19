using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using eSAR.StudentServiceRef;
using System.IO;
using System.Drawing.Imaging;
using Telerik.WinControls.UI;

namespace eSAR.Admission_and_Registration
{
    public partial class frmStudentDetails : Telerik.WinControls.UI.RadForm
    {
        private string szStudentID = string.Empty;
        private Image img = null;
        public string Op { get; set; }
        public Student SelectedStudent { get; set; }

        public frmStudentDetails()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

 
        private void frmStudentDetails_Load(object sender, EventArgs e)
        {
            pvStudent.SelectedPage = pvStudent.Pages[0];

            if (Op.Equals("new"))
            {
                GenerateStudentID();
                txtAge.Text = calculateAge(dtDOB.Value).ToString();
            }

            if (Op.Equals("edit"))
            {
                SetFields();
            }
        }

        private void SetFields()
        {
            txtStudentId.Enabled = false;
            txtStudentId.Text = SelectedStudent.StudentId;
            txtFirstName.Text = SelectedStudent.FirstName;
            txtMiddleName.Text = SelectedStudent.MiddleName;
            txtLastName.Text = SelectedStudent.LastName;
            txtSchoolLastAttended.Text = SelectedStudent.SchoolLastAttended;
            cmbGradeLevel.Text = SelectedStudent.GradeLevel;
            if (SelectedStudent.Image != null)
            {
                img = byteArrayToImage(SelectedStudent.Image);
                pbImage.BackgroundImage = ResizeImage(100, 100, img);
            }
            if (SelectedStudent.Gender == "M")
                cmbGender.Text = "Male";
            if (SelectedStudent.Gender == "F")
                cmbGender.Text = "Female";
            dtDOB.Value = (DateTime)SelectedStudent.DOB;
            txtAge.Text = calculateAge(dtDOB.Value).ToString();
            if (SelectedStudent.MadrasahEnrolled == true)
                chkMadrasah.Checked = true;
            else
                chkMadrasah.Checked = false;

            if (SelectedStudent.Card == true)
                chkReportCard.Checked = true;
            else
                chkReportCard.Checked = false;

            if (SelectedStudent.GoodMoral == true)
                chkGoodMoral.Checked = true;
            else
                chkGoodMoral.Checked = false;

            if (SelectedStudent.BirthCertificate == true)
                chkBirthCertificate.Checked = true;
            else
                chkBirthCertificate.Checked = false;

            txtPOB_Street.Text = SelectedStudent.POBAddress;
            txtPOB_Town.Text = SelectedStudent.POBTownCity;
            txtPOB_Province.Text = SelectedStudent.POBProvince;
            txtPOB_Brgy.Text = SelectedStudent.POBBarangay;

            txtHA_Street.Text = SelectedStudent.HomeAddress;
            txtHA_Brgy.Text = SelectedStudent.HomeBarangay;
            txtHA_Town.Text = SelectedStudent.HomeTownCity;
            txtHA_Province.Text = SelectedStudent.HomeProvince;
            
            txtFather_FullName.Text = SelectedStudent.FathersName;
            txtFather_Occupation.Text = SelectedStudent.FathersOccupation;
            txtFather_EducAttainment.Text = SelectedStudent.FathersEducation;
            txtFather_Income.Text = SelectedStudent.FathersAverageYearlyIncome.ToString();

            txtMother_FullName.Text = SelectedStudent.MothersMaidenName;
            txtMother_Occupation.Text = SelectedStudent.MothersOccupation;
            txtMother_Income.Text = SelectedStudent.MothersAverageYearlyIncome.ToString();
            txtMother_EducAttainment.Text = SelectedStudent.MothersEducation;


            txtGuardian_FullName.Text = SelectedStudent.GuardiansName;
            txtGuardian_Income.Text = SelectedStudent.GuardiansAverageYearlyIncome.ToString();
            txtGuardian_Occupation.Text = SelectedStudent.GuardiansOccupation;
        }

        private void GenerateStudentID()
        {
            StudentServiceClient studentService = new StudentServiceClient();
            szStudentID = studentService.GenerateStudentId();
            txtStudentId.Text = szStudentID;
        }

        private void btnInsertImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "BMP Files (*.bmp, *.dib, *.rle|*.bmp;*.dib;*.rle|" +
                                   "JPEG Files (*.jpg,*.jpeg,*.jpe, *.jfif|*.jpg;*.jpeg;*.jpe;*.jfif|" +
                                   "GIF Files (*.gif)|*.gif|" +
                                   "PNG Files (*.png)|*.png|" +
                                   "All Files (*.*)|*.*";
            DialogResult res = openFileDialog1.ShowDialog();

            if (res == DialogResult.OK)
            {
                pbImage.BackgroundImage = ResizeImage(100, 100, Image.FromFile(openFileDialog1.FileName));
            }
        }

        //convert image to byte array
        public byte[] imageToByteArray(System.Drawing.Image imageIn, System.Drawing.Imaging.ImageFormat imgFormat)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, imgFormat);
            ms.Dispose();
            ms.Close();
            return ms.ToArray();
        }

        //convert byte array to image
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        //Image resizing
        public static System.Drawing.Image ResizeImage(int maxWidth, int maxHeight, System.Drawing.Image Image)
        {
            int width = Image.Width;
            int height = Image.Height;
            if (width > maxWidth || height > maxHeight)
            {
                //The flips are in here to prevent any embedded image thumbnails -- usually from cameras
                //from displaying as the thumbnail image later, in other words, we want a clean
                //resize, not a grainy one.
                Image.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipX);
                Image.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipX);

                float ratio = 0;
                if (width > height)
                {
                    ratio = (float)width / (float)height;
                    width = maxWidth;
                    height = Convert.ToInt32(Math.Round((float)width / ratio));
                }
                else
                {
                    ratio = (float)height / (float)width;
                    height = maxHeight;
                    width = Convert.ToInt32(Math.Round((float)height / ratio));
                }

                //return the resized image
                return Image.GetThumbnailImage(width, height, null, IntPtr.Zero);
            }


            //return the original resized image
            return Image;
        }

        private void txtStudentId_Leave(object sender, EventArgs e)
        {
            Student student = new Student();
            string msg = string.Empty;
            StudentServiceClient studentService = new StudentServiceClient();

            if (txtStudentId.Text == string.Empty) txtStudentId.Text = szStudentID;


            student = studentService.GetStudent(txtStudentId.Text, ref msg);
            if (student.StudentId != null)
            {
                MessageBox.Show("Student ID already exist!");
                txtStudentId.Text = szStudentID;
                txtStudentId.Focus();
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirstName.Text) && !string.IsNullOrEmpty(txtLastName.Text))
                Save();
            else
            {
                MessageBox.Show("First Name and Last Name should not be empty");
                return;
            }
        }

        private void Save()
        {
            string szGender = string.Empty;
            if (cmbGender.Text == "Female") szGender = "F";
            if (cmbGender.Text == "Male") szGender = "M";
            Boolean ret = false;
            string message = String.Empty;

            byte[] bImage = null;
            if (pbImage.BackgroundImage != null) bImage = imageToByteArray(pbImage.BackgroundImage, ImageFormat.Png);

            StudentServiceClient studentService = new StudentServiceClient();

            Student student = new Student()
            {
                StudentId = txtStudentId.Text,
                FirstName = txtFirstName.Text,
                MiddleName = txtMiddleName.Text,
                LastName = txtLastName.Text,
                Image = bImage,
                SchoolLastAttended = txtSchoolLastAttended.Text,
                GradeLevel = cmbGradeLevel.Text,
                DOB = dtDOB.Value,
                MadrasahEnrolled = chkMadrasah.Checked,
                Card = chkReportCard.Checked,
                GoodMoral = chkGoodMoral.Checked,
                BirthCertificate = chkBirthCertificate.Checked,
                POBAddress = txtPOB_Street.Text,
                POBBarangay = txtPOB_Brgy.Text,
                POBProvince = txtPOB_Province.Text,
                POBTownCity = txtPOB_Town.Text,
                HomeAddress = txtHA_Street.Text,
                HomeProvince = txtHA_Province.Text,
                HomeBarangay = txtHA_Brgy.Text,
                HomeTownCity = txtHA_Town.Text,
                FathersName = txtFather_FullName.Text,
                FathersOccupation = txtFather_Occupation.Text,
                FathersAverageYearlyIncome = double.Parse(txtFather_Income.Text),
                FathersEducation = txtFather_EducAttainment.Text,
                MothersMaidenName = txtMother_FullName.Text,
                MothersEducation = txtMother_EducAttainment.Text,
                MothersOccupation = txtMother_Occupation.Text,
                MothersAverageYearlyIncome = double.Parse(txtMother_Income.Text),
                GuardiansName = txtGuardian_FullName.Text,
                GuardiansOccupation = txtGuardian_Occupation.Text,
                GuardiansAverageYearlyIncome = double.Parse(txtGuardian_Income.Text)
            };



            if (Op.Equals("edit"))
                ret = studentService.UpdateStudent(ref student, ref message);
            else
                ret = studentService.CreateStudent(ref student, ref message);

            if (ret)
                MessageBox.Show("Saved Successfully");
            else
                MessageBox.Show("Error Saving");

            Close();
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            RadTextBox textBox = (RadTextBox)sender;
            // only allow one decimal point
            if (e.KeyChar == '.' && textBox.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && textBox.SelectionLength == 0)
            {
                if (textBox.Text.IndexOf('.') > -1 && textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 3)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtFather_Income_TextChanged(object sender, EventArgs e)
        {
            if (txtFather_Income.Text == string.Empty) txtFather_Income.Text = "0";
        }

        private void txtMother_Income_TextChanged(object sender, EventArgs e)
        {
            if (txtMother_Income.Text == string.Empty) txtMother_Income.Text = "0";
        }

        private void txtGuardian_Income_TextChanged(object sender, EventArgs e)
        {
            if (txtGuardian_Income.Text == string.Empty) txtGuardian_Income.Text = "0";
        }

        private void txtStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private int calculateAge(DateTime dob)
        {
            int ageInYears = 0;

            ageInYears = DateTime.Now.Year - dob.Year;
            
            if (ageInYears > 0)
            {
                if (DateTime.Now.Month < dob.Month)
                    ageInYears--;

                if (DateTime.Now.Month == dob.Month)
                    if (DateTime.Now.Day < dob.Day)
                        ageInYears--;
            }
            else
                ageInYears = 0;
          

            return ageInYears;
        }

        private void dtDOB_ValueChanged(object sender, EventArgs e)
        {
            if (dtDOB.Value != null || dtDOB.Text != string.Empty)
                txtAge.Text = calculateAge(dtDOB.Value).ToString();
        }
    }
}
