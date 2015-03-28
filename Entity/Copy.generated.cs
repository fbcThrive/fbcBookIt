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
	
	// Table Name: Copy
	public partial class Copy: BASE_Entity
	{
		// Primary Keys
		public System.Guid CopyId { get; set; }
	
		// Non-Primary columns
		public System.Boolean? Consumable { get; set; }
		public System.Int32 CopyNumber { get; set; }
		// Foreign Key to FormatType
		public System.Guid FormatID { get; set; }
		public System.Int32? Hours { get; set; }
		public System.Int32? Pages { get; set; }
		public System.Boolean? ProofRead { get; set; }
		// Foreign Key to CopyStatus
		public System.Int32? StatusID { get; set; }
		// Foreign Key to Title
		public System.Guid TitleID { get; set; }
		public System.Int32 Volume { get; set; }
	
	}
	
	public class CopyMap: EntityTypeConfiguration<Copy>
	{
		public CopyMap()
		{
			// Map entity to table
			ToTable("Copy");
	
			// Map property to column
			Property(t => t.Consumable).HasColumnName("Consumable");
			Property(t => t.CopyId).HasColumnName("CopyId");
			Property(t => t.CopyNumber).HasColumnName("CopyNumber");
			Property(t => t.FormatID).HasColumnName("FormatID");
			Property(t => t.Hours).HasColumnName("Hours");
			Property(t => t.Pages).HasColumnName("Pages");
			Property(t => t.ProofRead).HasColumnName("ProofRead");
			Property(t => t.StatusID).HasColumnName("StatusID");
			Property(t => t.TitleID).HasColumnName("TitleID");
			Property(t => t.Volume).HasColumnName("Volume");
	
			// Primary Key
			HasKey(t => t.CopyId);
	
			// Additional property mappings
			Property(t => t.CopyId)
				.IsRequired();
	
			Property(t => t.CopyNumber)
				.IsRequired();
	
			Property(t => t.FormatID)
				.IsRequired();
	
			Property(t => t.TitleID)
				.IsRequired();
	
			Property(t => t.Volume)
				.IsRequired();
	
	
		}
	}
	
	public static partial class CopyHelper
	{
		public static void AssignNewPK
			(this Copy aCopy)
		{
			aCopy.CopyId = Guid.NewGuid().CombGuid();
		}
	
		/// <summary> 
		/// This code is fragile in that is ASSUMES that integer primary keys ARE
		/// AUTO-INCREMENTING columns whose value is governed by the database 
		/// server and that Guid primary keys are NOT "computed" values but rather 
		/// those whose column value is set by the client and/or server in a 
		/// fashion NOT governed by the database server.
		/// </summary>
		public static bool IsNew
			(this Copy aCopy)
		{
			if (aCopy == null)
			{
				throw 
					new ArgumentNullException
						(
							"aCopy"
							, "Entity instance cannot be null!"
						);
			}
			bool vResult = 
				(aCopy.CopyId == Guid.Empty);
			return vResult;
		}
	
		public static void AssignTo
			(Copy aFrom, Copy aTo)
		{
			aTo.Consumable = aFrom.Consumable;
			aTo.CopyId = aFrom.CopyId;
			aTo.CopyNumber = aFrom.CopyNumber;
			aTo.FormatID = aFrom.FormatID;
			aTo.Hours = aFrom.Hours;
			aTo.Pages = aFrom.Pages;
			aTo.ProofRead = aFrom.ProofRead;
			aTo.StatusID = aFrom.StatusID;
			aTo.TitleID = aFrom.TitleID;
			aTo.Volume = aFrom.Volume;
		}
	
		public static void AssignToNoPrimaryKeys
			(Copy aFrom, Copy aTo)
		{
			aTo.Consumable = aFrom.Consumable;
			aTo.CopyNumber = aFrom.CopyNumber;
			aTo.FormatID = aFrom.FormatID;
			aTo.Hours = aFrom.Hours;
			aTo.Pages = aFrom.Pages;
			aTo.ProofRead = aFrom.ProofRead;
			aTo.StatusID = aFrom.StatusID;
			aTo.TitleID = aFrom.TitleID;
			aTo.Volume = aFrom.Volume;
		}
	
		public static void AssignToJustPrimaryKeys
			(Copy aFrom, Copy aTo)
		{
			aTo.CopyId = aFrom.CopyId;
		}
	
		public static void AssignFrom
			(this Copy aTo, Copy aFrom)
		{
			aTo.Consumable = aFrom.Consumable;
			aTo.CopyId = aFrom.CopyId;
			aTo.CopyNumber = aFrom.CopyNumber;
			aTo.FormatID = aFrom.FormatID;
			aTo.Hours = aFrom.Hours;
			aTo.Pages = aFrom.Pages;
			aTo.ProofRead = aFrom.ProofRead;
			aTo.StatusID = aFrom.StatusID;
			aTo.TitleID = aFrom.TitleID;
			aTo.Volume = aFrom.Volume;
		}
	
		public static void AssignFromNoPrimaryKeys
			(this Copy aTo, Copy aFrom)
		{
			aTo.Consumable = aFrom.Consumable;
			aTo.CopyNumber = aFrom.CopyNumber;
			aTo.FormatID = aFrom.FormatID;
			aTo.Hours = aFrom.Hours;
			aTo.Pages = aFrom.Pages;
			aTo.ProofRead = aFrom.ProofRead;
			aTo.StatusID = aFrom.StatusID;
			aTo.TitleID = aFrom.TitleID;
			aTo.Volume = aFrom.Volume;
		}
	
		public static void AssignFromJustPrimaryKeys
			(this Copy aTo, Copy aFrom)
		{
			aTo.CopyId = aFrom.CopyId;
		}
	
	}
}
