#region License Information (Apache 2.0)
/*
   Copyright 2023 Prahlad Yeri

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace simplepms
{


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
            //check another instance running
            var exists = System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1;
            if (exists) {
                MessageBox.Show(string.Format("Another instance of {0} is already running.", Application.ProductName));
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
