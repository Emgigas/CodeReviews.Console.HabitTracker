﻿using Microsoft.Data.Sqlite;

string connectionString = @"Data Source=habit-Tracker.db";

using (var connection = new SqliteConnection(connectionString))
{
    connection.Open();
    var tableCmd = connection.CreateCommand();

    tableCmd.CommandText = 
        @"CREATE TABLE IF NOT EXISTS pet_the_dog (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Date TEXT,
            Quantity INTEGER
            )";

    tableCmd.ExecuteNonQuery();

    connection.Close();
    
}

DisplayMenu();

void DisplayMenu()
{
    Console.WriteLine("MAIN MENU\n");
    Console.WriteLine("What would you like to do?\n");
    Console.WriteLine("Type 0 to Close the Application.");
    Console.WriteLine("Type 1 to View All Records.");
    Console.WriteLine("Type 2 to Insert a Record.");
    Console.WriteLine("Type 3 to Update a Record.");
    Console.WriteLine("Type 4 to Delete a Record.");
    Console.WriteLine("--------------------------------\n");
}
