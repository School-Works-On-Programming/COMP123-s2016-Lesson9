using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Lesson9
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            /**
             * <summary>
             * 
             * </summary>
             **/
            InitializeComponent();
        }


        //PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++

            /**
             *<summary>
             * This mehtod cleras the UsernameTExtBox and the PasswordTextBox 
             * </summary> 
             * 
             * @private
             * @method _clearForm
             * @returns {void}
             **/
        private void _clearForm()
        {
            UsernameTextBox.Clear();
            PasswordTextBox.Clear(); 
        }

        /**
         * <summary>
         * This is the LoginButton click even handler 
         * </summary>
         * 
         * @private
         * @method LoginButton_Click
         * @param {object} sender
         * @param {EventArgs} e 
         * @returns {void}
         */
        private void LoginButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Username: " + UsernameTextBox.Text);
            Debug.WriteLine("Password: " + PasswordTextBox.Text);
            this._clearForm(); 
        }
    }
}
