using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Postro2
{
    public static class DatabaseManager
    {

        private static SQLiteConnection connection;
        public static string DatabaseFilename { get { return _DatabaseFilename; } }
        private static string _DatabaseFilename;

        // when creating a db, filename should have the extension ".sqlite"
        public static void CreateDatabase(string filename)
        {
            // load existing database, and if it doesn't exist, create it
            _DatabaseFilename = filename;
            if (File.Exists(filename)) return;
  
            SQLiteConnection.CreateFile(filename);
        }

        public static void Connect(string filename)
        {
            if (!File.Exists(filename))
            {
                var result = MessageBox.Show("The database doesn't exist. Would you like to create it?", "Database", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("This software requires a database to function. Exiting...", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string con_info = string.Format("Data Source = {0}; Version = 3;", filename);
            connection = new SQLiteConnection(con_info);
            connection.Open();

            _DatabaseFilename = filename;
        }



        public static void Command(string command)
        {
            if (!CheckDatabaseExists()) return;

            (new SQLiteCommand(command, connection)).ExecuteNonQuery();
        }

        private static bool CheckDatabaseExists()
        {
            bool exists = File.Exists(DatabaseFilename);

            if (!exists) MessageBox.Show(string.Format("The database with filename \"{0}\" doesn't exist. It must be created before connecting.", DatabaseFilename), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

            return exists;
        }

        // for scrolling through data, read from the reader
        // e.g. 
        // while((reader = CommandWithReader(command)).Read()) Console.Writeline(reader["name"]);
        // http://blog.tigrangasparian.com/2012/02/09/getting-started-with-sqlite-in-c-part-one/
        public static async Task<System.Data.Common.DbDataReader> CommandWithReader(string command)
        {
            if (!CheckDatabaseExists()) return null;
            return await (new SQLiteCommand(command, connection)).ExecuteReaderAsync();
        }

        public static string GenerateUniqueID()
        {
            return Guid.NewGuid().ToString();
        }

        // =======================================================================================================
        // PROPRIETARY DATABASE MANAGER STUFF INVOLVING POSTERS
        // =======================================================================================================

        public static bool AddPosterToDB(Poster poster)
        {
            try
            {
                Command(string.Format("INSERT INTO Posters (PosterTitle, Condition, Count, ID, Holds, Price) VALUES ('{0}', '{1}', {2}, '{3}', {4}, {5});", poster.Title, Poster.ConditionToString(poster.PosterCondition), poster.Count.ToString(), poster.ID, poster.Holds.ToString(), poster.Pricing * 100));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

    }
}
