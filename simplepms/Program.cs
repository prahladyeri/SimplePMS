using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;

namespace simplepms
{
    /**
     * Special class to store globally used variables, functions, etc.
     */
    public static class Util {
        public static SQLiteConnection conn;
        public static SQLiteCommand cmd;
    }

    /**
     * Special class for tagging controls with information
     */
    public class ControlTag {
        public bool Required = false;
        public string Name = "";

        public ControlTag(string name, bool required) {
            this.Required = required;
            this.Name = name;
        }
    }

    /**
     * Special class for storing combo box items
     * @todo: move this to a utility library later
     */
    public class TextData {
        protected string text;
        protected string data;

        public TextData (string text, string data)
        {
            this.text = text;
            this.data = data;
        }

        public override string ToString()
        {
            return text;
        }

        public string Data {
            get {
                return data;
            }
            set {
                this.data = value;
            }
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
