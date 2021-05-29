using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Educacao.Infra.Repository
{
    public abstract class Database
    {
                private readonly IConfiguration _configuration;
        public Database(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public SqlConnection Connect()
        {
var connection= new SqlConnection(_configuration.GetSection("ConnectionString").Value);
            return connection;
        }
    }
}
