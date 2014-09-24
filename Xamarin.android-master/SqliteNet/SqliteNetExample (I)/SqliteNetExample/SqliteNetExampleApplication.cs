/*
SqliteNetExampleApplication.cs
Clase Customer para el modelo
Autor: Hugo Gómez Arenas
Email: hugo.gomeza@outlook.com
http://xamurais.com
*/

using System;
using Android.App;
using Android.Runtime;
using SQLite;
using SqliteNetExample.Models;


namespace SqliteNetExample
{
	[Application]
	public class SqliteNetExampleApplication : Application
	{

		public SqliteNetExampleApplication(IntPtr handle, JniHandleOwnership transfer)
			: base(handle, transfer)
		{
		}

		public override void OnCreate()
		{
			base.OnCreate();

			//Obtiene el path 
			string folder = System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal);
			string dbPath = System.IO.Path.Combine (folder, "bussines2.db");

			//Verifica si la base de datos existe
			if(!System.IO.File.Exists (dbPath))
			{
				// Crea la base de datos y las tablas
				var db = new SQLiteConnection (dbPath);
				db.CreateTable<Customer>();

			}
		}
	}
}

