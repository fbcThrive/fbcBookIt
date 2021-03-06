//-----------------------------------------------------------------------------
// <auto-generated> 
// ^^^ Comment out the above line to allow ReSharper to validate the 
//  using clauses.
//	This code was generated from a template.
//
//	Manual changes to this file may cause unexpected behavior in your 
//	application.
//	Manual changes to this file will be overwritten if the code is 
//	regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------

namespace FbcBookIt.Entity
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.Data.Entity.ModelConfiguration;
	using System.ComponentModel.DataAnnotations.Schema;
	//using AWEFramework.AWEExtensions;
	using FbcBookIt.Utility;
	using System.Collections.Generic;
	
	// Table Name: Title
	public partial class Title: BASE_Entity
	{
		// Primary Keys
		public System.Guid TitleID { get; set; }
	
		// Non-Primary columns
		public System.Decimal? AcceleratedReading { get; set; }
		public System.Boolean Active { get; set; }
		public System.String Author { get; set; }
		public System.String Copyright { get; set; }
		public System.String Grade { get; set; }
		public System.String ISBN10 { get; set; }
		public System.String ISBN13 { get; set; }
		public System.String Name { get; set; }
		public System.String Publisher { get; set; }
	
	}
	
	public class TitleMap: EntityTypeConfiguration<Title>
	{
		public TitleMap()
		{
			// Map entity to table
			ToTable("Title");
	
			// Map property to column
			Property(t => t.AcceleratedReading).HasColumnName("AcceleratedReading");
			Property(t => t.Active).HasColumnName("Active");
			Property(t => t.Author).HasColumnName("Author");
			Property(t => t.Copyright).HasColumnName("Copyright");
			Property(t => t.Grade).HasColumnName("Grade");
			Property(t => t.ISBN10).HasColumnName("ISBN10");
			Property(t => t.ISBN13).HasColumnName("ISBN13");
			Property(t => t.Name).HasColumnName("Name");
			Property(t => t.Publisher).HasColumnName("Publisher");
			Property(t => t.TitleID).HasColumnName("TitleID");
	
			// Primary Key
			HasKey(t => t.TitleID);
	
			// Additional property mappings
			Property(t => t.Active)
				.IsRequired();
	
			Property(t => t.Name)
				.IsRequired();
	
			Property(t => t.TitleID)
				.IsRequired();
	
	
		}
	}
	
	public static partial class TitleHelper
	{
		public static void AssignNewPK
			(this Title aTitle)
		{
			aTitle.TitleID = Guid.NewGuid().CombGuid();
		}
	
		/// <summary> 
		/// This code is fragile in that is ASSUMES that integer primary keys ARE
		/// AUTO-INCREMENTING columns whose value is governed by the database 
		/// server and that Guid primary keys are NOT "computed" values but rather 
		/// those whose column value is set by the client and/or server in a 
		/// fashion NOT governed by the database server.
		/// </summary>
		public static bool IsNew
			(this Title aTitle)
		{
			if (aTitle == null)
			{
				throw 
					new ArgumentNullException
						(
							"aTitle"
							, "Entity instance cannot be null!"
						);
			}
			bool vResult = 
				(aTitle.TitleID == Guid.Empty);
			return vResult;
		}
	
		public static void AssignTo
			(Title aFrom, Title aTo)
		{
			aTo.AcceleratedReading = aFrom.AcceleratedReading;
			aTo.Active = aFrom.Active;
			aTo.Author = aFrom.Author;
			aTo.Copyright = aFrom.Copyright;
			aTo.Grade = aFrom.Grade;
			aTo.ISBN10 = aFrom.ISBN10;
			aTo.ISBN13 = aFrom.ISBN13;
			aTo.Name = aFrom.Name;
			aTo.Publisher = aFrom.Publisher;
			aTo.TitleID = aFrom.TitleID;
		}
	
		public static void AssignToNoPrimaryKeys
			(Title aFrom, Title aTo)
		{
			aTo.AcceleratedReading = aFrom.AcceleratedReading;
			aTo.Active = aFrom.Active;
			aTo.Author = aFrom.Author;
			aTo.Copyright = aFrom.Copyright;
			aTo.Grade = aFrom.Grade;
			aTo.ISBN10 = aFrom.ISBN10;
			aTo.ISBN13 = aFrom.ISBN13;
			aTo.Name = aFrom.Name;
			aTo.Publisher = aFrom.Publisher;
		}
	
		public static void AssignToJustPrimaryKeys
			(Title aFrom, Title aTo)
		{
			aTo.TitleID = aFrom.TitleID;
		}
	
		public static void AssignFrom
			(this Title aTo, Title aFrom)
		{
			aTo.AcceleratedReading = aFrom.AcceleratedReading;
			aTo.Active = aFrom.Active;
			aTo.Author = aFrom.Author;
			aTo.Copyright = aFrom.Copyright;
			aTo.Grade = aFrom.Grade;
			aTo.ISBN10 = aFrom.ISBN10;
			aTo.ISBN13 = aFrom.ISBN13;
			aTo.Name = aFrom.Name;
			aTo.Publisher = aFrom.Publisher;
			aTo.TitleID = aFrom.TitleID;
		}
	
		public static void AssignFromNoPrimaryKeys
			(this Title aTo, Title aFrom)
		{
			aTo.AcceleratedReading = aFrom.AcceleratedReading;
			aTo.Active = aFrom.Active;
			aTo.Author = aFrom.Author;
			aTo.Copyright = aFrom.Copyright;
			aTo.Grade = aFrom.Grade;
			aTo.ISBN10 = aFrom.ISBN10;
			aTo.ISBN13 = aFrom.ISBN13;
			aTo.Name = aFrom.Name;
			aTo.Publisher = aFrom.Publisher;
		}
	
		public static void AssignFromJustPrimaryKeys
			(this Title aTo, Title aFrom)
		{
			aTo.TitleID = aFrom.TitleID;
		}
	
	}
}
