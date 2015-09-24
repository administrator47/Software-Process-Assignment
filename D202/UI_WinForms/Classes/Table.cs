using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UI_WinForms.Classes
{
    class Table
    {
        private static SqlConnection sql_conn = null;

        private static SqlConnection ConnectDB()
        {
            if (sql_conn == null)
            {
                sql_conn = new SqlConnection(
                     "server=TFS;" +
                     "database=study3;" +
                     "Integrated Security=sspi"
                 );
                sql_conn.Open();
            }
            return sql_conn;
        }

        protected static SqlCommand CreateCommand(string sql_query, object[] sql_params)
        {
            var cmd = ConnectDB().CreateCommand();
            cmd.CommandText = sql_query;
            if (sql_params != null)
            {
                for (int i = 0; i < sql_params.Length; i++)
                {
                    var sql_param = new SqlParameter(i.ToString(), sql_params[i]);
                    //if (sql_param.Value == null)
                    //{
                    //    sql_param.IsNullable = true;
                    //    sql_param.SqlValue = DBNull.Value;
                    //}

                    cmd.Parameters.Add(sql_param);
                }
            }
            return cmd;
        }

        protected static SqlDataReader ExecuteReader(string sql_query, object[] sql_params)
        {
            var cmd = CreateCommand(sql_query, sql_params);
            return cmd.ExecuteReader();
        }

        protected static int ExecuteNonQuery(string sql_query, object[] sql_params)
        {
            var cmd = CreateCommand(sql_query, sql_params);
            return cmd.ExecuteNonQuery();
        }

        protected bool loaded = false;
        public bool Loaded
        {
            get { return loaded; }
        }

        protected bool dirty = false;
        public bool Dirty
        {
            get { return dirty; }
        }

        protected string fRecordedID;
        protected virtual void SetRecordedID(string id)
        {
            fRecordedID = id;
        }

        public string RecordedID
        {
            get { return fRecordedID; }
        }

        protected string fID;
        protected virtual void SetID(string id)
        {
            fID = id;
        }

        public string ID
        {
            get
            {
                return fID;
            }
            set
            {
                dirty = dirty || fID != value;
                SetID(value);
            }
        }

        public string EffectiveID
        {
            get
            {
                return (RecordedID != null ? RecordedID : ID);
            }
        }

        public Table(string id)
        {
            loaded = false;
            dirty = false;
            fRecordedID = null;
            fID = id;
        }

        public virtual void Refresh()
        {
            throw new NotImplementedException();
        }

        public virtual void Update()
        {
            throw new NotImplementedException();
        }
    }

    class Table<T>: Table where T: Table
    {
        private static Dictionary<string, Table> rows = new Dictionary<string, Table>(10);
     
        public static T FromID(string id)
        {
            // Which subclass is calling us?
            Type t = typeof(T);

            try
            {
                return (T) rows[id];
            }
            catch (KeyNotFoundException)
            {
                Object[] parameters = {id};
                return (T) System.Activator.CreateInstance(t, parameters);
            }
            catch (ArgumentNullException)
            {
                return null;
            }
        }

        public static string TableName()
        {
            // Which subclass is calling us?
            Type t = typeof(T);

            return (string) t.GetMethod("TableName").Invoke(null, null);
        }

        protected static T[] LoadFromDataReader(SqlDataReader dr)
        {
            var result = new List<T>();

            try
            {
                while (dr.Read())
                {
                    var id = dr.GetString(0);
                    T obj = Table<T>.FromID(id);
                    if (obj.Dirty && obj.RecordedID == null)
                    {
                        // ID clash with new unsaved record.
                        // FIXME: Mutable primary database keys cause major headaches!
                    }
                    (obj as Table<T>).SetRecordedID(id);
                    result.Add(obj);
                }
            }
            finally
            {
                dr.Close();
            }

            return result.ToArray<T>();            
        }

        public static T[] LoadIDs()
        {
            var dr = ExecuteReader(String.Format("select id from {0}", TableName()), null);
            return LoadFromDataReader(dr);
        }

        public Table(string id)
            : base(id)
        {
            rows.Add(id, this);
        }

        protected override void SetRecordedID(string id)
        {
            var old_id = EffectiveID;
            base.SetRecordedID(id);
            var new_id = EffectiveID;
            if (old_id != new_id)
            {
                rows.Remove(old_id);
                rows.Add(new_id, this);
            }
        }

        protected override void SetID(string id)
        {
            var old_id = EffectiveID;
            base.SetID(id);
            var new_id = EffectiveID;
            if (old_id != new_id)
            {
                rows.Remove(old_id);
                rows.Add(new_id, this);
            }
        }

        public override void Refresh()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            if (dirty && RecordedID != null && RecordedID != ID)
            {
                object[] sql_params = { RecordedID, ID };
                ExecuteNonQuery(String.Format("update {0} set id=@1 where id=@0", TableName()), sql_params);
                SetRecordedID(ID);
            }
        }
    }
}
