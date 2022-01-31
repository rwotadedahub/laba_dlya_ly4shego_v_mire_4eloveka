using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace HR_department
{
    public partial class Form1 : Form
    {
        private SqlConnection HR_departmentDBConnection = null; // класс благодаря ему проходят все операции с базой данных через созданные подключения
        //sqlConnection это присвоими имя можно было присвоить и например WorkersConnection
        private SqlDataAdapter sqlDataAdapter = null;

       // private SqlCommandBuilder sqlBuilder = null;
        public Form1()  
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {

            HR_departmentDBConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["HR_departmentDB_kluch"].ConnectionString);
            HR_departmentDBConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Workers", HR_departmentDBConnection);

            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView1.DataSource = db.Tables[0];

       
        }

      

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                $"INSERT INTO [Workers] (Surname, Name, Patronymic, Birthday, Department, PhoneNumber, Street, House, Flat) VALUES(N'{TBSurname.Text}', N'{TBName.Text}', N'{TBPatronymic.Text}', N'{TBBirthday.Text}', N'{TBDepartment.Text}', N'{TBPhoneNumber.Text}', N'{TBStreet.Text}', N'{TBHouse.Text}', N'{TBFlat.Text}' )",
                HR_departmentDBConnection);

          


            TBSurname.Text = "";
            TBName.Text = "";
             TBPatronymic.Text = "";
            TBBirthday.Text = "";
            TBDepartment.Text = "";
            TBPhoneNumber.Text = "";
            TBStreet.Text = "";
            TBHouse.Text = "";
            TBFlat.Text = "";

             
           
        

            MessageBox.Show(command.ExecuteNonQuery().ToString("Добавлено"));
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Workers", HR_departmentDBConnection);

            DataSet db = new DataSet();
            dataAdapter.Fill(db);
           dataGridView1.DataSource = db.Tables[0];
        }

        private void TBSearch_TextChanged(object sender, EventArgs e)  // тут делаю поиск по фамилии (по факту фильтрацию)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =$"Surname LIKE '%{TBSearch.Text}%'";    // сначало делает то что в скобках а после открытия по последнему слову
        }

        private void comboBoxFilterDepartment_SelectedIndexChanged(object sender, EventArgs e) // Здесь  фильтрую таблицу по отделам
        {
            switch (comboBoxFilterDepartment.SelectedIndex)
            {
                case 0:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
                    break;
                case 1:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Department = 'Аналитический' "; // c {comboBoxFilterDepartment.Items.}
                    break;
                case 2:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Department  = 'Хозяйственный'";
                    break;
                case 3:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Department = 'Рабочий'";
                    break;
                case 4:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Department  = 'Управляющий'"; // начало
                    break;
                case 5:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Department = 'Охраняющий'";
                    break;
               
            }
        }

        private  void DeleteButton_Click(object sender, EventArgs e)
        {
           

            SqlCommand command = new SqlCommand(
                "DELETE FROM [Workers] WHERE [Id]=@id"
                , HR_departmentDBConnection);

            command.Parameters.AddWithValue("Id", TBForIDDelete.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString("Удалено"));
            


             SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Workers", HR_departmentDBConnection);
             DataSet db = new DataSet();
             dataAdapter.Fill(db);
             dataGridView1.DataSource = db.Tables[0];

            TBForIDDelete.Text = "";

        }

        private  void UpdateButton_Click(object sender, EventArgs e)
        {                
            SqlCommand command = new SqlCommand(
"UPDATE [Workers] SET [Surname] = @Surname, [Name] = @Name, [Patronymic] = @Patronymic, [Birthday] = @Birthday, [Department] = @Department," +
" [PhoneNumber] = @PhoneNumber, [Street] = @Street, [House] = @House, [Flat] = @Flat  WHERE [Id] = @Id  "
, HR_departmentDBConnection); 



            command.Parameters.AddWithValue("Id", tbID.Text);
            command.Parameters.AddWithValue("Surname", TBSurname1.Text);
            command.Parameters.AddWithValue("Name", TBName1.Text);
            command.Parameters.AddWithValue("Patronymic", TBPatronymic1.Text);
            command.Parameters.AddWithValue("Birthday", TBBirthday1.Text);
            command.Parameters.AddWithValue("Department", TBDepartment1.Text);
            command.Parameters.AddWithValue("PhoneNumber", TBPhoneNumber1.Text);
            command.Parameters.AddWithValue("Street", TBStreet1.Text);
            command.Parameters.AddWithValue("House", TBHouse1.Text);
            command.Parameters.AddWithValue("Flat", TBFlat1.Text);
            
            MessageBox.Show(command.ExecuteNonQuery().ToString("Отредактировано"));           

            tbID.Text = "";
            TBSurname1.Text = "";
            TBName1.Text = "";
            TBPatronymic1.Text = "";
            TBBirthday1.Text = "";
            TBDepartment1.Text = "";
            TBPhoneNumber1.Text = "";
            TBStreet1.Text = "";
            TBHouse1.Text = "";
            TBFlat1.Text = "";
                      
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Workers", HR_departmentDBConnection);

            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView1.DataSource = db.Tables[0]; 
        }

        /*   if (!string.IsNullOrEmpty(tbID.Text) && !string.IsNullOrWhiteSpace(tbID.Text))
           {
               SqlCommand command = new SqlCommand(
"UPDATE [Workers] SET  WHERE [Id] = @Id "
, HR_departmentDBConnection);

           }  */
    }
}
