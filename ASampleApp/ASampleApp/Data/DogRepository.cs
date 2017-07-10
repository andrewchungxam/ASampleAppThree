using System;
using System.Collections.Generic;
using SQLite;

using ASampleApp.Models;
using System.Linq;

namespace ASampleApp.Data
{
	public class DogRepository
	{

		private SQLiteConnection sqliteConnection;

		public DogRepository (string dbPath)
		{
			sqliteConnection = new SQLiteConnection (dbPath);
			sqliteConnection.CreateTable<Dog> ();

		}

		public void AddNewDog (string name, string furColor)
		{
			sqliteConnection.Insert (new Dog { Name = name, FurColor = furColor });

		}

		public void DeleteDog(Dog dog)
		{
           sqliteConnection.Delete(dog);

		}

		public void AddNewDogPhotoURL (string name, string furColor, string dogURL)
		{
			sqliteConnection.Insert (new Dog { Name = name, FurColor = furColor, DogPictureURL = dogURL });
		}

		public void AddNewDogPhotoFile (string name, string furColor, string dogFile)
		{
			sqliteConnection.Insert (new Dog { Name = name, FurColor = furColor, DogPictureFile = dogFile });
		}

		public void AddNewDogPhotoSource(string name, string furColor, string dogSource)
		{
            sqliteConnection.Insert(new Dog { Name = name, FurColor = furColor, DogPictureSource = dogSource });
		}


		public List<Dog> GetAllDogs ()
		{
			return sqliteConnection.Table<Dog> ().ToList ();
		}

		public Dog GetFirstDog ()
		{
			return sqliteConnection.Table<Dog> ().FirstOrDefault ();

		}

		public Dog GetLastDog ()
		{
			return sqliteConnection.Table<Dog> ().LastOrDefault ();

		}


	}
}
