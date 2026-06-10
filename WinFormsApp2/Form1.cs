using System;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        TextBox txtWeight = new TextBox { Location = new Point(50, 30), Width = 150 };
        TextBox txtTime = new TextBox { Location = new Point(50, 70), Width = 150 };
        ComboBox cmbExercise = new ComboBox { Location = new Point(50, 110), Width = 150 };
        Button btnCalc = new Button { Location = new Point(50, 150), Text = "Розрахувати", Width = 150 };
        Label lblResult = new Label { Location = new Point(50, 190), AutoSize = true, Text = "Результат: 0 ккал" };

        public Form1()
        {
            this.Size = new Size(300, 300);
            this.Text = "FitCalc";
            
            // Додаємо елементи на форму
            this.Controls.Add(new Label { Text = "Вага (кг):", Location = new Point(50, 10), AutoSize = true });
            this.Controls.Add(txtWeight);
            this.Controls.Add(new Label { Text = "Час (хв):", Location = new Point(50, 50), AutoSize = true });
            this.Controls.Add(txtTime);
            this.Controls.Add(new Label { Text = "Тип:", Location = new Point(50, 90), AutoSize = true });
            
            cmbExercise.Items.Add("Full Body");
            cmbExercise.Items.Add("Кардіо");
            this.Controls.Add(cmbExercise);
            
            this.Controls.Add(btnCalc);
            this.Controls.Add(lblResult);

            btnCalc.Click += BtnCalc_Click;
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double weight = Convert.ToDouble(txtWeight.Text);
                double time = Convert.ToDouble(txtTime.Text);
                double result = weight * time * 0.1; // Формула
                lblResult.Text = "Спалено: " + result.ToString("F1") + " ккал";
            }
            catch
            {
                MessageBox.Show("Введи коректні цифри!");
            }
        }
    }
}