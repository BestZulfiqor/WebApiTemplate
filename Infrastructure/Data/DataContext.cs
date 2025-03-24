﻿using System.Data;
using Npgsql;

namespace Infrastructure.Data;

public class DataContext
{
    private const string ConnectionString = "Host=localhost;Username=postgres;Password=9000;Database=online_store";

    public async Task<IDbConnection> GetConnectionAsync()
    {
        return new NpgsqlConnection(ConnectionString);
    }
}