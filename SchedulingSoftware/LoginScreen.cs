using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace SchedulingSoftware
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        public static CultureInfo culture = CultureInfo.CurrentCulture;
        public static RegionInfo region = RegionInfo.CurrentRegion;

        private string errorText;
        
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            Console.WriteLine("The current culture is {0} [{1}]",
                        culture.NativeName, culture.Name);
            Console.WriteLine("The current region is {0} [{1}]", region.NativeName, region.Name);

            if (culture.Name.StartsWith("es") || region.Name.StartsWith("es"))
            {
                titleLabel.Text = "Software de Programación";
                loginBox.Text = "Acceso";
                usernameLabel.Text = "Nombre de Usuario";
                passwordLabel.Text = "Contraseña";
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            bool error = false;
            errorText = "";
            usernameTextBox.BackColor = Color.White;
            passwordTextBox.BackColor = Color.White;

            // check to see if text boxes are filled out
            if (incompleteEntry())
            {
                MessageBox.Show(errorText, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check input for correctness
            if (usernameTextBox.Text.ToLower() != "test")
            {
                error = true;
                if (culture.Name.StartsWith("es") || region.Name.StartsWith("es"))
                {
                    errorText += "El nombre de usuario que ingresaste es incorrecto, inténtalo de nuevo.\n";
                }
                else
                {
                    errorText += "The username that was entered is incorrect, please try again.\n";
                }

                usernameTextBox.BackColor = Color.LightSalmon;
            }
            if (passwordTextBox.Text.ToLower() != "test")
            {
                error = true;
                if (culture.Name.StartsWith("es") || region.Name.StartsWith("es"))
                {
                    errorText += "La contraseña que ingresó es incorrecta, inténtelo de nuevo.\n";
                }
                else
                {
                    errorText += "The passord that was entered is incorrect, please try again.\n";
                }

                passwordTextBox.BackColor = Color.LightSalmon;
            }
            if (usernameTextBox.Text.ToLower() != passwordTextBox.Text.ToLower())
            {
                error = true;
                if (culture.Name.StartsWith("es") || region.Name.StartsWith("es"))
                {
                    errorText += "El nombre de usuario y la contraseña no coinciden, inténtelo de nuevo.\n";
                }
                else
                {
                    errorText += "The username and password do not match, please try again.\n";
                }
            }

            if (error)
            {
                MessageBox.Show(errorText, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        // incompleteEntry
        //      checks to see if any of the text box fields are missing information
        private bool incompleteEntry()
        {
            bool incomplete = false;

            if (usernameTextBox.Text.Length == 0)
            {
                if (culture.Name.StartsWith("es") || region.Name.StartsWith("es"))
                { 
                    errorText += "Por favor, especifique un nombre de usuario.\n"; 
                }
                else
                {
                    errorText += "Please specify a username.\n";
                }
                
                usernameTextBox.BackColor = Color.LightSalmon;
                incomplete = true;
            }
            if (passwordTextBox.Text.Length == 0)
            {
                if (culture.Name.StartsWith("es") || region.Name.StartsWith("es"))
                {
                    errorText += "Por favor especifique una contraseña.\n";
                }
                else
                {
                    errorText += "Please specify a password.\n";
                }
                passwordTextBox.BackColor = Color.LightSalmon;
                incomplete = true;
            }

            return incomplete;
        }
    }
}
