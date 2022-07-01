using System;
using System.Windows.Forms;

namespace TriviaClient
{
    internal static class Program
    {
        /// <summary>
        /// Main function of the whole program
        /// </summary>
        [STAThread]
        private static void Main()
        {
            if (!Socket.Connected)
            {
                MessageBox.Show($"There is no server which runs on {Socket.ServerAddress.PORT} port.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }

        /// <summary>
        /// Checks if all text boxes in the form fielded (also checks text boxes which is in groupbox/panel (recursively)
        /// </summary>
        /// <param name="controlCollection">Control collection (Form.Controls)</param>
        /// <returns>True, if all text boxes in the given control collection (form) fielded, either - false.</returns>
        public static bool UserFilled(Control.ControlCollection controlCollection)
        {
            foreach (Control c in controlCollection)
            {
                if (c is GroupBox || c is Panel) // if user input is inside groupbox/panel -> recursively search for it
                {
                    bool filled = UserFilled(c.Controls);
                    if (!filled)
                        return false;
                }

                if (c is TextBox textBox) // if it textbox - check that he isn't empty
                    if (textBox.Text == "")
                        return false;

                if (c is ListBox listBox) // if it list box - check that he is selectable, and any item selected
                    if (listBox.SelectionMode != SelectionMode.None)
                        if (listBox.SelectedIndex == -1)
                            return false;
            }
            return true;
        }
    }
}
