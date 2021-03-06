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
	
	// Table Name: Volume
	public partial class Volume: BASE_Entity
	{
		// Primary Keys
		public System.Guid VolumeID { get; set; }
	
		// Non-Primary columns
		public System.String Barcode { get; set; }
		// Foreign Key to Copy
		public System.Guid? CopyID { get; set; }
		public System.Int32? Pages { get; set; }
		public System.Int32? VolumeNumber { get; set; }
		// Foreign Key to VolumeStatus
		public System.Int32? VolumeStatusID { get; set; }
	
	}
	
	public class VolumeMap: EntityTypeConfiguration<Volume>
	{
		public VolumeMap()
		{
			// Map entity to table
			ToTable("Volume");
	
			// Map property to column
			Property(t => t.Barcode).HasColumnName("Barcode");
			Property(t => t.CopyID).HasColumnName("CopyID");
			Property(t => t.Pages).HasColumnName("Pages");
			Property(t => t.VolumeID).HasColumnName("VolumeID");
			Property(t => t.VolumeNumber).HasColumnName("VolumeNumber");
			Property(t => t.VolumeStatusID).HasColumnName("VolumeStatusID");
	
			// Primary Key
			HasKey(t => t.VolumeID);
	
			// Additional property mappings
			Property(t => t.VolumeID)
				.IsRequired();
	
	
		}
	}
	
	public static partial class VolumeHelper
	{
		public static void AssignNewPK
			(this Volume aVolume)
		{
			aVolume.VolumeID = Guid.NewGuid().CombGuid();
		}
	
		/// <summary> 
		/// This code is fragile in that is ASSUMES that integer primary keys ARE
		/// AUTO-INCREMENTING columns whose value is governed by the database 
		/// server and that Guid primary keys are NOT "computed" values but rather 
		/// those whose column value is set by the client and/or server in a 
		/// fashion NOT governed by the database server.
		/// </summary>
		public static bool IsNew
			(this Volume aVolume)
		{
			if (aVolume == null)
			{
				throw 
					new ArgumentNullException
						(
							"aVolume"
							, "Entity instance cannot be null!"
						);
			}
			bool vResult = 
				(aVolume.VolumeID == Guid.Empty);
			return vResult;
		}
	
		public static void AssignTo
			(Volume aFrom, Volume aTo)
		{
			aTo.Barcode = aFrom.Barcode;
			aTo.CopyID = aFrom.CopyID;
			aTo.Pages = aFrom.Pages;
			aTo.VolumeID = aFrom.VolumeID;
			aTo.VolumeNumber = aFrom.VolumeNumber;
			aTo.VolumeStatusID = aFrom.VolumeStatusID;
		}
	
		public static void AssignToNoPrimaryKeys
			(Volume aFrom, Volume aTo)
		{
			aTo.Barcode = aFrom.Barcode;
			aTo.CopyID = aFrom.CopyID;
			aTo.Pages = aFrom.Pages;
			aTo.VolumeNumber = aFrom.VolumeNumber;
			aTo.VolumeStatusID = aFrom.VolumeStatusID;
		}
	
		public static void AssignToJustPrimaryKeys
			(Volume aFrom, Volume aTo)
		{
			aTo.VolumeID = aFrom.VolumeID;
		}
	
		public static void AssignFrom
			(this Volume aTo, Volume aFrom)
		{
			aTo.Barcode = aFrom.Barcode;
			aTo.CopyID = aFrom.CopyID;
			aTo.Pages = aFrom.Pages;
			aTo.VolumeID = aFrom.VolumeID;
			aTo.VolumeNumber = aFrom.VolumeNumber;
			aTo.VolumeStatusID = aFrom.VolumeStatusID;
		}
	
		public static void AssignFromNoPrimaryKeys
			(this Volume aTo, Volume aFrom)
		{
			aTo.Barcode = aFrom.Barcode;
			aTo.CopyID = aFrom.CopyID;
			aTo.Pages = aFrom.Pages;
			aTo.VolumeNumber = aFrom.VolumeNumber;
			aTo.VolumeStatusID = aFrom.VolumeStatusID;
		}
	
		public static void AssignFromJustPrimaryKeys
			(this Volume aTo, Volume aFrom)
		{
			aTo.VolumeID = aFrom.VolumeID;
		}
	
	}
}
