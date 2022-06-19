using System;
using System.Drawing;
using System.Windows.Forms;

namespace validate
{
    public class Form1 : System.Windows.Forms.Form
    {
        private Label label1, label2, label3, label4, label5, label6;
        private TextBox nameTextBox;
        private NumericUpDown ageUpDownPicker;
        private ComboBox favoriteColorComboBox;
        private ErrorProvider ageErrorProvider, nameErrorProvider, favoriteColorErrorProvider;

        // It tells the compiler that you're in a Single Thread Apartment model. 
        // This is an evil COM thing, it's usually used for Windows Forms (GUI's) 
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }
        public Form1()
        {
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.nameTextBox = new TextBox();
            this.ageUpDownPicker = new NumericUpDown();
            this.favoriteColorComboBox = new ComboBox();
            // Name Label
            this.label1.Location = new System.Drawing.Point(56, 32);
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.Text = "Name:";
            // Age Label
            this.label2.Location = new System.Drawing.Point(40, 64);
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.Text = "Age (3-5)";
            // Favorite Color Label
            this.label3.Location = new System.Drawing.Point(24, 96);
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.Text = "Favorite color";
            // ErrorBlinkStyle.AlwaysBlink Label
            this.label4.Location = new System.Drawing.Point(264, 32);
            this.label4.Size = new System.Drawing.Size(160, 23);
            this.label4.Text = "ErrorBlinkStyle.AlwaysBlink";
            // ErrorBlinkStyle.BlinkIfDifferentError Label
            this.label5.Location = new System.Drawing.Point(264, 64);
            this.label5.Size = new System.Drawing.Size(200, 23);
            this.label5.Text = "ErrorBlinkStyle.BlinkIfDifferentError";
            // ErrorBlinkStyle.NeverBlink Label
            this.label6.Location = new System.Drawing.Point(264, 96);
            this.label6.Size = new System.Drawing.Size(200, 23);
            this.label6.Text = "ErrorBlinkStyle.NeverBlink";
            // Name TextBox
            this.nameTextBox.Location = new System.Drawing.Point(112, 32);
            this.nameTextBox.Size = new System.Drawing.Size(120, 20);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Validated += new System.EventHandler(this.nameTextBox1_Validated);
            // Age NumericUpDown
            this.ageUpDownPicker.Location = new System.Drawing.Point(112, 64);
            this.ageUpDownPicker.Maximum = new System.Decimal(new int[] { 150, 0, 0, 0 });
            this.ageUpDownPicker.TabIndex = 4;
            this.ageUpDownPicker.Validated += new System.EventHandler(this.ageUpDownPicker_Validated);
            // Favorite Color ComboBox
            this.favoriteColorComboBox.Items.AddRange(new object[] { "None", "Red", "Yellow", "Green", "Blue", "Purple" });
            this.favoriteColorComboBox.Location = new System.Drawing.Point(112, 96);
            this.favoriteColorComboBox.Size = new System.Drawing.Size(120, 21);
            this.favoriteColorComboBox.TabIndex = 5;
            this.favoriteColorComboBox.Validated += new
            System.EventHandler(this.favoriteColorComboBox_Validated);

            // Set up how the form should be displayed and add the controls to the form.
            this.ClientSize = new System.Drawing.Size(464, 150);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.label6,this.label5,this.label4,this.label3,
                this.favoriteColorComboBox,this.ageUpDownPicker,
                this.label2,this.label1,this.nameTextBox
            });
            this.Text = "Error Provider Example";

            // Create and set the ErrorProvider for each data entry control.
            nameErrorProvider = new System.Windows.Forms.ErrorProvider();
            nameErrorProvider.SetIconAlignment(this.nameTextBox, ErrorIconAlignment.MiddleRight);
            nameErrorProvider.SetIconPadding(this.nameTextBox, 2);
            nameErrorProvider.BlinkRate = 1000;
            nameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            ageErrorProvider = new System.Windows.Forms.ErrorProvider();
            ageErrorProvider.SetIconAlignment(this.ageUpDownPicker, ErrorIconAlignment.MiddleRight);
            ageErrorProvider.SetIconPadding(this.ageUpDownPicker, 2);
            ageErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            favoriteColorErrorProvider = new System.Windows.Forms.ErrorProvider();
            favoriteColorErrorProvider.SetIconAlignment(this.favoriteColorComboBox, ErrorIconAlignment.MiddleRight);
            favoriteColorErrorProvider.SetIconPadding(this.favoriteColorComboBox, 2);
            favoriteColorErrorProvider.BlinkRate = 1000;
            favoriteColorErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
        }
        private void nameTextBox1_Validated(object sender, System.EventArgs e)
        {
            if (IsNameValid())
            {
                // Clear the error, if any, in the error provider.
                nameErrorProvider.SetError(this.nameTextBox, String.Empty);
            }
            else
            {
                // Set the error if the name is not valid.
                nameErrorProvider.SetError(this.nameTextBox, "Name is required.");
            }
        }
        private void ageUpDownPicker_Validated(object sender, System.EventArgs e)
        {
            if (IsAgeTooYoung())
            {
                // Set the error if the age is too young.
                ageErrorProvider.SetError(this.ageUpDownPicker, "Age not old enough");
            }
            else if (IsAgeTooOld())
            {
                // Set the error if the age is too old.
                ageErrorProvider.SetError(this.ageUpDownPicker, "Age is too old");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                ageErrorProvider.SetError(this.ageUpDownPicker, String.Empty);
            }
        }
        private void favoriteColorComboBox_Validated(object sender, System.EventArgs e)
        {
            if (!IsColorValid())
            {
                // Set the error if the favorite color is not valid.
                favoriteColorErrorProvider.SetError(this.favoriteColorComboBox, "Must select a color.");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                favoriteColorErrorProvider.SetError(this.favoriteColorComboBox, String.Empty);
            }
        }
        // Functions to verify data.
        private bool IsNameValid()
        {
            // Determine whether the text box contains a zero-length string.
            return (nameTextBox.Text.Length > 0);
        }
        private bool IsAgeTooYoung()
        {
            // Determine whether the age value is less than three.
            return (ageUpDownPicker.Value < 3);
        }
        private bool IsAgeTooOld()
        {
            // Determine whether the age value is greater than five.
            return (ageUpDownPicker.Value > 5);
        }
        private bool IsColorValid()
        {
            // Determine whether the favorite color has a valid value.
            return ((favoriteColorComboBox.SelectedItem != null) &&
            (!favoriteColorComboBox.SelectedItem.ToString().Equals("None")));
        }
    }
}
