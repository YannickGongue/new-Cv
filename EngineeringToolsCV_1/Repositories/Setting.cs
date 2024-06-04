using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace EngineeringToolsCV_1.Repositories
{
    public class Setting
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                            Initial Catalog=Lebenslauf;
                                            Integrated Security=True"; 

        public string ConnectionString
        {
            get
            {
                return this.connectionString;
            }

            set
            {
                this.connectionString = value;
            }
        }      
    }
}
