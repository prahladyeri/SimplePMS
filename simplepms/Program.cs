using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace simplepms
{
    //special class for storing combo box items
    //@todo: move this to a utility library later
    public class TextData {
        protected string text;
        protected object data;

        public TextData (string text, object data)
        {
            this.text = text;
            this.data = data;
        }

        public override string ToString()
        {
            return text;
        }

        public object Data {
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
