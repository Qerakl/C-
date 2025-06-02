using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms; // Директива для работы с Windows Forms
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;
using Microsoft.Identity.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _52
{
    public partial class areg : Form
    {
        public areg()
        {
            InitializeComponent();
        }

        private static int ban = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string logi = log.Text.Trim(); // Получаем логин из текстового поля
            string pass = pas.Text.Trim();

            if (!string.IsNullOrWhiteSpace(logi) && !string.IsNullOrWhiteSpace(pass))
            {
                using (SqlConnection cn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;"))
                {
                    try
                    {
                        cn.Open();

                        // Проверка на существование пользователя и блокировку
                        SqlCommand cmdUsers = new SqlCommand("SELECT ban FROM pol WHERE logi = @logi AND pass = @pass;", cn);
                        cmdUsers.Parameters.AddWithValue("@logi", logi);
                        cmdUsers.Parameters.AddWithValue("@pass", pass);
                        SqlCommand cmdAdmin = new SqlCommand("SELECT COUNT(*) FROM adm WHERE logi = @logi AND pass = @pass;", cn);
                        cmdAdmin.Parameters.AddWithValue("@logi", logi);
                        cmdAdmin.Parameters.AddWithValue("@pass", pass);
                        int adminCount = (int)cmdAdmin.ExecuteScalar();



                        using (SqlDataReader reader = cmdUsers.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int banStatus = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);

                                if (banStatus == 1)
                                {
                                    MessageBox.Show("Вы заблокированы!!!", "Блокировка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                else
                                {
                                    rereg re = new rereg(logi);
                                    re.Show();
                                    this.Hide();
                                }
                            }
                            else if (adminCount > 0)
                            {
                                adm admForm = new adm();
                                admForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните оба поля: логин и пароль.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void log_TextChanged(object sender, EventArgs e)
        {

        }
    }
}