using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace simplepms
{
    /**
     * Special class to store globally used variables, functions, etc.
     */
    public static class Util
    {
        public static SQLiteDataAdapter adapter;
        public static DataSet dataset;
        public static SQLiteConnection conn;



        public static DataTable getTable(string name)
        {
            //return name;
            return dataset.Tables[name];
        }

        public static int saveData(string table)
        {
            //DataSet ds = getTable(tableName).DataSet;
            DataTable changes = dataset.Tables[table].GetChanges();
            if (changes == null) return 0;
            //SQLiteDataAdapter da = adapters[tableName];
            adapter.SelectCommand.CommandText = "select * from " + table + ";";
            SQLiteCommandBuilder scb = new SQLiteCommandBuilder(adapter);
            scb.ConflictOption = ConflictOption.CompareRowVersion;
            //int cnt = adapter.Update(changes);
            //int cnt = adapter.Update(dataset, table);
            int cnt = adapter.Update(getTable(table));
            //dataset.Tables[table].AcceptChanges();
            return cnt;
            //scb.last
        }

        public static DataRow findById(string table, int id) {
            foreach (DataRow row in dataset.Tables[table].Rows) {
                if (int.Parse(row["id"].ToString()) == id) return row;
            }
            return null;
        }

        public static void refreshdb() {
            //check for any pending database changes before quitting
            for (int i = 0; i < Util.adapter.TableMappings.Count; i++)
            {
                string tb = Util.adapter.TableMappings[i].DataSetTable;
                Util.saveData(tb);
            }
            //now re-init
            initdb();

        }

        public static void initdb()
        {
            string dbpath = AppDomain.CurrentDomain.BaseDirectory + "pms.db";
            string connstr = @"Data Source=" + dbpath + @";Version=3;New=True;Compress=True";
            bool dbexists = File.Exists(dbpath);
            Util.conn = new SQLiteConnection(connstr);
            Util.conn.Open();
            if (!dbexists)
            {
               SQLiteCommand  cmd = new SQLiteCommand(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "schema.sql"), Util.conn);
                cmd.ExecuteNonQuery();
            }
            //fetch all tables to adapter
            //@todo: add a new mapping here when you add a new table
            adapter = new SQLiteDataAdapter(@"select * from projects; 
            select * from milestones; 
            select * from tasks; 
            select * from timesheet;
            select d.name[Project], c.name [Milestone], b.name [Task], fdate [From], tdate [To], a.notes Notes from timesheet a, tasks b, milestones c, projects d where a.task_id=b.id and b.milestone_id=c.id and c.project_id=d.id order by [To] desc;
                ", conn);
            adapter.TableMappings.Add("Table", "projects");
            adapter.TableMappings.Add("Table1", "milestones");
            adapter.TableMappings.Add("Table2", "tasks");
            adapter.TableMappings.Add("Table3", "timesheet");
            adapter.TableMappings.Add("Table4", "vw_timesheet");
            adapter.RowUpdated += new EventHandler<System.Data.Common.RowUpdatedEventArgs>(adapter_RowUpdated);
            dataset = new DataSet();
            adapter.Fill(dataset);
        }

        static void adapter_RowUpdated(object sender, System.Data.Common.RowUpdatedEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.StatementType == StatementType.Insert)
            {
                //object id = e.Command.Parameters["@id"];
                SQLiteCommand cmd = new SQLiteCommand("select last_insert_rowid();", conn);
                int id = int.Parse( cmd.ExecuteScalar().ToString() );
                e.Row["id"] = id;
                //int id = = cmd.ExecuteScalar();
                //DataRow row = getTable(e.Row.Table.TableName);
                //e.Row
                //e.Row.Table.AcceptChanges();
                //e.Row.AcceptChanges();
            }
        }
    }
}
