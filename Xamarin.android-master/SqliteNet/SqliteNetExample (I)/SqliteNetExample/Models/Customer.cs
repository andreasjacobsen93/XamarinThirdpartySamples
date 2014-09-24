/*
Customer.cs
Clase Customer para el modelo
Autor: Hugo Gómez Arenas
Email: hugo.gomeza@outlook.com
http://xamurais.com
*/

using System;
using SQLite;

namespace SqliteNetExample.Models
{
	public class Customer
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }

		public string Name { get; set; }

		public string Address { get; set; }

	}
}

