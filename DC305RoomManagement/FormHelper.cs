using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DC305RoomManagement
{
    public static class FormHelper
    {
        /// <summary>
        /// Clear Values of Fields of the particular Type (TextBox, ComboBox)
        /// </summary>
        public static void ClearFields(Control mainControl, Type type)
        {
            List<Control> items = GetControls(mainControl, type).ToList();
            string test = type.Name;
            foreach (Control item in items)
            {
                switch (type.Name)
                {
                    case "TextBox":
                        (item as TextBox).Text = string.Empty;
                        break;
                    case "ComboBox":
                        (item as ComboBox).Text = string.Empty;
                        (item as ComboBox).SelectedIndex = -1;
                        break;
                    case "NumericUpDown":
                        (item as NumericUpDown).Value = 0;
                        break;
                }
            }
        }

        /// <summary>
        /// Get All Controls by the Type in the Control
        /// </summary>
        /// <param name="control">The main control containing necessary controls</param>
        /// <param name="type">The Type of necessary controls</param>
        /// <returns>Collection of Controls</returns>
        private static IEnumerable<Control> GetControls(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetControls(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
    }
}
